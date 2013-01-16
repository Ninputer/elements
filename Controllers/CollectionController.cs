using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using elements.Models;

namespace elements.Controllers
{
    public class CollectionController : Controller
    {
        private CollectionContext db = new CollectionContext();

        //
        // GET: /Collection/

        public ActionResult Index()
        {
            return View(db.Collections.ToList());
        }

        //
        // GET: /Collection/Details/5

        public ActionResult Details(int id = 0)
        {
            Collection collection = db.Collections.Find(id);
            if (collection == null)
            {
                return HttpNotFound();
            }
            return View(collection);
        }

        //
        // GET: /Collection/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Collection/Create

        [HttpPost]
        public ActionResult Create(Collection collection)
        {
            if (ModelState.IsValid)
            {
                db.Collections.Add(collection);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(collection);
        }

        //
        // GET: /Collection/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Collection collection = db.Collections.Find(id);
            if (collection == null)
            {
                return HttpNotFound();
            }
            return View(collection);
        }

        //
        // POST: /Collection/Edit/5

        [HttpPost]
        public ActionResult Edit(Collection collection)
        {
            if (ModelState.IsValid)
            {
                db.Entry(collection).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(collection);
        }

        //
        // GET: /Collection/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Collection collection = db.Collections.Find(id);
            if (collection == null)
            {
                return HttpNotFound();
            }
            return View(collection);
        }

        //
        // POST: /Collection/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Collection collection = db.Collections.Find(id);
            db.Collections.Remove(collection);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}