using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASP.Controllers
{
    public class HomeController : Controller
    {
        // GET: First
        public string Index()
        {
            return "Hello there";
        }

        public string Index2()
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
    }
}