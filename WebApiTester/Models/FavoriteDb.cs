using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApiTester.Models 
{
    public class FavoriteDb : DbContext
    {

        public FavoriteDb() : base("DefaultConnection")
        {
            
        }

        public DbSet<Favorite> Favorites { get; set; }


    }
}