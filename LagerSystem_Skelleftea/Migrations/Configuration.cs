namespace LagerSystem_Skelleftea.Migrations
{
    using LagerSystem_Skelleftea.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LagerSystem_Skelleftea.DataAccessLayer.StoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(LagerSystem_Skelleftea.DataAccessLayer.StoreContext context)
        {

            context.Items.AddOrUpdate(
                i => i.ItemID,
                new StockItem { ItemID = 1, Name = "Handgranat", Description = "Väldigt dödlig", Price = 200, Shelf = "Hylla A" },
                new StockItem { ItemID = 2, Name = "K-Pist", Description = "Väldigt dödlig", Price = 2000, Shelf = "Hylla A" },
                new StockItem { ItemID = 3, Name = "Pistol Luger", Description = "Väldigt dödlig", Price = 1500, Shelf = "Hylla A" },
                new StockItem { ItemID = 4, Name = "Bajonett", Description = "Väldigt dödlig", Price = 300, Shelf = "Hylla A" }

                );
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
