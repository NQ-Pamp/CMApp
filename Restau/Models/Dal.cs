using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restau.Models
{
    public class Dal : IDal
    {
        private EntityContext bddContext;

        public Dal()
        {
            bddContext = new EntityContext();
        }

        public List<Restaurant> GetRestaurants()
        {
            return bddContext.Restaurants.ToList();
        }

        public void CreateRestaurants(string name, string phone)
        {
            Restaurant r = new Restaurant() { Name = name, Phone = phone };
            bddContext.Restaurants.Add(r);
            bddContext.SaveChanges();
        }

        public void Dispose()
        {
            bddContext.Dispose();
        }
    }
}