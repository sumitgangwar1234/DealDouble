using DealDouble.Services;
using DealDouble.Web.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DealDouble.Web.Controllers
{
    public class HomeController : Controller
    {
        AuctionsService service = new AuctionsService();
        public ActionResult Index()
        {
            AuctionsViewModel vmodel = new AuctionsViewModel();


            vmodel.PageTitle = "Home Page";
            vmodel.PageDescription = "This is Home Page";
            vmodel.AllAuctions = service.GetAllAuction();
           

            vmodel.PromoteAuctions = service.GetPromotedAuction();
            

            return View(vmodel); 
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}