using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP.Models
{
    public class Customers
    {
        public List<Customer> GetCustomers()
        {
            return new List<Customer>()
            {
                new Customer(){FirstName = "Malik", LastName = "TOUDERT", Age = 30},
                new Customer(){FirstName = "Clem", LastName = "LARCHER", Age = 29}
            };
        }
    }
}