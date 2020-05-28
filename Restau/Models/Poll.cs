using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restau.Models
{
    public class Poll
    {
        public int id { get; set; }
        public DateTime date { get; set; }
        public virtual List<vote> Votes { get; set; }
    }
}