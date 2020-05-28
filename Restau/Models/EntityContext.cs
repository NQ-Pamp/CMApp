using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Restau.Models
{
    public class EntityContext : DbContext
    {
        public DbSet<Poll> Polls { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
    }
}