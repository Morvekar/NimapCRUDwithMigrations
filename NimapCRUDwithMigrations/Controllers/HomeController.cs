using NimapCRUDwithMigrations.Models;
using PagedList;
using PagedList.Mvc;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NimapCRUDwithMigrations.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home

        Services db = new Services();
        public ActionResult Index(int? i)
        {
            var data = db.Products.ToList().ToPagedList(i ?? 1,10);
            return View(data);
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Product product)
        {
            db.Products.Add(product);
            int dt = db.SaveChanges();
            if (dt > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Edit(int CID)
        {
            var val = db.Products.Where(model => model.CategoryID == CID).FirstOrDefault();
            return View(val);
        }

        [HttpPost]
        public ActionResult Edit(Product product)
        {
            db.Entry(product).State = EntityState.Modified;
            int dt =db.SaveChanges();
            if(dt > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }

        public ActionResult Delete(int CID)
        {
            var val = db.Products.Where(model => model.CategoryID == CID).FirstOrDefault();
            return View(val);
        }

        [HttpPost]
        public ActionResult Delete(Product product)
        {
            db.Entry(product).State = EntityState.Deleted;
            int dt = db.SaveChanges();
            if(dt > 0)
            {
                return RedirectToAction("Index");
            }
            return View();
        }
    }
}