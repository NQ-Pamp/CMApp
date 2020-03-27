using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ASP.Models;

namespace ASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: First
        //https://localhost:44353/home/index2

        public ActionResult Index(string id)
        {
            if (string.IsNullOrWhiteSpace(id))
            {
                return View("Error");
            }
            else
            {
                //ViewData["Name"] = id;
                ViewBag.name = id;
                return View();
            }
        }

        public ActionResult Index2()
        {
            return View("Index");
        }

        public ActionResult Customers()
        {
            var customersModel = new Customers();
            ViewBag.Customers = customersModel.GetCustomers();

            return View();
        }

        public ActionResult FindCustomer(string id)
        {
            ViewBag.Name = id;

            var customerModel = new Customers();
            var customer = customerModel.GetCustomers().FirstOrDefault(c => c.FirstName == id);

            if (customer != null)
            {
                ViewBag.Age = customer.Age;
                return View("Found");
            }

            return View("NotFound");
        }

        #region MyRegion
        public string Index_test()
        {
            return "Hello there";
        }

        public string Index_test2()
        {
            return "Moving on";
        }

        public string Index3(int id)
        {
            return "Trying params : " + id;
        }

        public string index4(int? nep)
        {
            return "Trying nullable param : " + nep;
        }

        public string index5(string word)
        {
            return "Hello" + word;
        } 
        #endregion




    }
}