using System;
using Restau.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Restau.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void CreateRestaurantTest()
        {
            Dal dal = new Dal();

            string createdRestau = "barabol";
            string createdPhone = "0633623201";

            dal.CreateRestaurants(createdRestau, createdPhone);
            List<Restaurant> restaurants = dal.GetRestaurants();


            Assert.IsNotNull(restaurants);
            Assert.AreEqual(1, restaurants.Count);
            Assert.AreEqual(createdRestau, restaurants[0].Name);
            Assert.AreEqual(createdPhone, restaurants[0].Phone);

        }
    }
}
