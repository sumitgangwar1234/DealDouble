using DealDouble.Data;
using DealDouble.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DealDouble.Services
{
   public  class CategoiesService
    {
        public List<Category> GetAllCategories()
        {
            DealDoubleContext context = new DealDoubleContext();
            return context.categories.ToList();
         
        }


      


    }
}
