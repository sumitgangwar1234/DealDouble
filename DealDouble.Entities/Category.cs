using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDouble.Entities
{
   public  class Category:BaseEntity 
    {
        public String  Name { get; set; }
        public String Description { get; set; }

        public List<Auction> Auctions { get; set; }

    }
}
