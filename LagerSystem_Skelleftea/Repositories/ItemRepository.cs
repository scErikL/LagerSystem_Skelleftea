using LagerSystem_Skelleftea.DataAccessLayer;
using LagerSystem_Skelleftea.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace LagerSystem_Skelleftea.Repositories
{
    public class ItemRepository
    {

        private StoreContext ctx;

        public ItemRepository()
        {
            ctx = new StoreContext();
        }

        public IEnumerable<StockItem> GetAllItems()
        {
            return ctx.Items.OrderBy(i=>i.Name);
        }

        public IEnumerable<StockItem> SortItemsByCol(string sortCol)
        {
            var lista = ctx.Items.AsEnumerable().OrderBy(o=>o.GetType().GetProperty(sortCol).GetValue(o,null));
            return lista;
        }



        public void SaveStockItem(StockItem item)
        {
            ctx.Items.Add(item);
            ctx.SaveChanges();
        }


        public StockItem GetItemById(int id)
        {
            return ctx.Items.FirstOrDefault(b => b.ItemID == id);

        }

        public void UpdateStockItem(StockItem item)
        {
            ctx.Entry(item).State = EntityState.Modified;
            ctx.SaveChanges();
        }

        public void DeleteItem(int id)
        {
            StockItem item = ctx.Items.Find(id);
            ctx.Items.Remove(item);
            ctx.SaveChanges();

        }
    }
}