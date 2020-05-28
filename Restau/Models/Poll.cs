using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restau.Models
{
    public class Poll
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public virtual List<vote> Votes { get; set; }
    }
}