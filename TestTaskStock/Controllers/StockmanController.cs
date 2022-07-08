using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using TestTaskStock.Models;

namespace TestTaskStock.Controllers
{
    public class StockmanController : Controller
    {
        private StockContext db = new StockContext();

        // GET: Stockman
        public ActionResult Index()
        {
            return View(db.Stockmans.ToList());
        }

        // GET: Stockman/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stockman stockman = db.Stockmans.Find(id);
            if (stockman == null)
            {
                return HttpNotFound();
            }
            return View(stockman);
        }

        // GET: Stockman/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Stockman/Create
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StockmanID,FullName")] Stockman stockman)
        {
            if (ModelState.IsValid)
            {
                db.Stockmans.Add(stockman);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(stockman);
        }

        // GET: Stockman/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stockman stockman = db.Stockmans.Find(id);
            if (stockman == null)
            {
                return HttpNotFound();
            }
            return View(stockman);
        }

        // POST: Stockman/Edit/5
        // Чтобы защититься от атак чрезмерной передачи данных, включите определенные свойства, для которых следует установить привязку. Дополнительные 
        // сведения см. в статье https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StockmanID,FullName")] Stockman stockman)
        {
            if (ModelState.IsValid)
            {
                db.Entry(stockman).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(stockman);
        }

        // GET: Stockman/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Stockman stockman = db.Stockmans.Find(id);
            if (stockman == null)
            {
                return HttpNotFound();
            }
            return View(stockman);
        }

        // POST: Stockman/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Stockman stockman = db.Stockmans.Find(id);
            db.Stockmans.Remove(stockman);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
