using DealDouble.Entities;
using DealDouble.Services;
using DealDouble.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDouble.Web.Controllers
{
    public class AuctionsController : Controller
    {
        // GET: Auction

        CategoiesService categoriesService = new CategoiesService();

        [HttpGet]
        public ActionResult Index()
        {
            AuctionsService auctionservice = new AuctionsService();

            ListingAuctionsViewModel model = new ListingAuctionsViewModel();

            model.Auctions = auctionservice.GetAllAuction();
            if (Request.IsAjaxRequest())
            {
                return PartialView(model);
            }
            else
            {
                return View(model);
            }

        }


        [HttpGet]
        public ActionResult Create()
        {
            CreateAuctionsViewModel model = new CreateAuctionsViewModel();
            model.categories = categoriesService.GetAllCategories();
            return PartialView(model);
        }


        // post: Auction
        [HttpPost]
        public ActionResult Create(CreateAuctionsViewModel model)
        {
            Auction auction = new Auction();
            auction.Title = model.Title;
            auction.categoryID = model.categoryID;
            auction.Description = model.Description;
            auction.ActualAmount = model.ActualAmount;
            auction.StartingTime = model.StartingTime;
            auction.EndTime = model.EndTime;

            //LINQ
            var pictureIDs = model.AuctionPictures.Split(new char[] { ',' }, StringSplitOptions.RemoveEmptyEntries).Select(ID => int.Parse(ID)).ToList();
            auction.AuctionPictures = new List<AuctionPicture>();
            auction.AuctionPictures.AddRange(pictureIDs.Select(x => new AuctionPicture() { PictureID = x }).ToList());


            AuctionsService service = new AuctionsService();
            service.SaveAuction(auction);
            return RedirectToAction("Index");
        }



        [HttpGet]
        public ActionResult Edit(int ID)
        {
            AuctionsService service = new AuctionsService();
            var auctions = service.GetAuctionsByID(ID);


            return PartialView(auctions);
        }


        // post: Auction
        [HttpPost]
        public ActionResult Edit(Auction auction)
        {
            AuctionsService service = new AuctionsService();
            service.UpdateAuction(auction);
            return RedirectToAction("Index");
        }


        [HttpGet]
        public ActionResult Delete(int ID)
        {
            AuctionsService service = new AuctionsService();
            var auctions = service.GetAuctionsByID(ID);


            return PartialView(auctions);
        }

        [HttpPost]
        public ActionResult Delete(Auction auction)
        {
            AuctionsService service = new AuctionsService();
            service.DeleteAuction(auction);
            return RedirectToAction("Index");
        }



        [HttpGet]
        [HandleError]
        public ActionResult Details(int ID)
        {
            AuctionsService service = new AuctionsService();
            var auctions = service.GetAuctionsByID(ID);


            return View(auctions);
        }

    }
}