using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restau.Models
{
    public class vote
    {
        public int id { get; set; }
        public virtual Restaurant Restaurant { get; set; }
        public virtual User User { get; set; }

    }
}