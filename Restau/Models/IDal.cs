using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restau.Models
{
    interface IDal : IDisposable
    {
        List<Restaurant> GetRestaurants();

        public void CreateRestaurants()
        {
        }
    }
}