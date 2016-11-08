using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace LagerSystem_Skelleftea.DataAccessLayer
{
    public class StoreContext : DbContext
    {
        public StoreContext() : base("DefaultConnection") { }

        public DbSet<Models.StockItem> Items { get; set; }
    }
}