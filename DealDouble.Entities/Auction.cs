using System;
using System.Collections.Generic;
using System.Text;

namespace DealDouble.Entities
{
   public class Auction:BaseEntity
    {
        public virtual Category Category { get; set; }
        public int categoryID { get; set; } 
        public string Title { get; set; }
   
        public string Description { get; set; }
        public decimal ActualAmount { get; set; }
        public DateTime StartingTime { get; set; }

        public DateTime EndTime { get; set; }

        public virtual List<AuctionPicture> AuctionPictures { get; set; }
      
    }
}
