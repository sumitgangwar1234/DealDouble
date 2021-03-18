using DealDouble.Data;
using DealDouble.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDouble.Services
{
   public  class AuctionsService
    {
        public List<Auction> GetAllAuction()
        {
            DealDoubleContext context = new DealDoubleContext();
            return context.Auctions.ToList();
         
        }


        public List<Auction> GetPromotedAuction()
        {
            DealDoubleContext context = new DealDoubleContext();
            return context.Auctions.Take(4).ToList();

        }
        public void SaveAuction(Auction auction)
        {
            DealDoubleContext context = new DealDoubleContext();
            context.Auctions.Add(auction);
            context.SaveChanges();
        }

        public Auction GetAuctionsByID(int ID)
        {
            DealDoubleContext context = new DealDoubleContext();
            return context.Auctions.Find(ID);
          
        }

        //public Auction GetAuctionsByIDURL(int ID)
        //{
        //    DealDoubleContext context = new DealDoubleContext();
           

        //    return context.Auctions.Include(ID=>ID.Pictures);

        //}

        public void UpdateAuction(Auction auction)
        {
            DealDoubleContext context = new DealDoubleContext();
            context.Entry(auction).State = System.Data.Entity.EntityState.Modified;
            context.SaveChanges();
      
        }

        public void DeleteAuction(Auction auction)
        {
            DealDoubleContext context = new DealDoubleContext();
            context.Entry(auction).State = System.Data.Entity.EntityState.Deleted;
            context.Auctions.Remove(auction);

            context.SaveChanges();

        }



    }
}
