using DealDouble.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DealDouble.Web.ViewModels
{

    public class  ListingAuctionsViewModel : PageViewModel
    {
        public List<Auction> Auctions { get; set; }

    }

public class AuctionsViewModel: PageViewModel
    {
        public List<Auction> AllAuctions { get; set; }

        public List<Auction> PromoteAuctions { get; set; }

    }



    public class CreateAuctionsViewModel : PageViewModel
    {

       
        public int categoryID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal ActualAmount { get; set; }
        public DateTime StartingTime { get; set; }

        public DateTime EndTime { get; set; }

        public string AuctionPictures { get; set; }

        public List<Category> categories { get; set; }

    }


    public class EditAuctionsViewModel : PageViewModel
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal ActualAmount { get; set; }
        public DateTime StartingTime { get; set; }

        public DateTime EndTime { get; set; }

        public string AuctionPictures { get; set; }
        public string URL { get; set; }

    }

}