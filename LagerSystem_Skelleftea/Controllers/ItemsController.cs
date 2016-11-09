using LagerSystem_Skelleftea.Models;
using LagerSystem_Skelleftea.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LagerSystem_Skelleftea.Controllers
{
    public class ItemsController : Controller
    {
        private ItemRepository repo = new ItemRepository();
        
        // GET: Items
        public ActionResult Index(string Search="", string sort = "Name")
        {
            return View(repo.SortItemsByCol(Search, sort));
        }

        /*GET:
        public ActionResult Sort(string sort="Name")
        {
            return View(repo.SortItemsByCol(sort));

        }*/
        
        //GET: Create Item
        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        
        [HttpPost]
        public ActionResult Create([Bind(Include = "Name, Price, Shelf, Description")] StockItem  item)
        {

            if (ModelState.IsValid)
            {
                repo.SaveStockItem(item);
                return RedirectToAction("Index");

            }
            return View(item);
        }

        //GET: Details/Id
        [HttpGet]
        public ActionResult Details(int id)
        {
            return View(repo.GetItemById(id));

        }

        //GET: Create Item
        [HttpGet]
        public ActionResult Edit(int id)
        {
            return View(repo.GetItemById(id));
        }

        [HttpPost]
        public ActionResult Edit([Bind(Include = "ItemID, Name, Price, Shelf, Description")] StockItem item)
        {

            if (ModelState.IsValid)
            {
                repo.UpdateStockItem(item);
                return RedirectToAction("Index");

            }
            return View(item);
        }

        //GET: Create Item
        [HttpGet]
        public ActionResult Delete(int id)
        {
            return View(repo.GetItemById(id));
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            repo.DeleteItem(id);
            return RedirectToAction("Index");


        }




         

    }
}