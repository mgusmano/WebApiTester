namespace WebApiTester.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using WebApiTester.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<WebApiTester.Models.FavoriteDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(WebApiTester.Models.FavoriteDb context)
        {
            context.Favorites.AddOrUpdate(d => d.Name,
                     new Favorite() { Name = "Engineering" },
                     new Favorite() { Name = "Sales" },
                     new Favorite() { Name = "Shipping" },
                     new Favorite() { Name = "Human Resources" }
                ); 
        }
    }
}
