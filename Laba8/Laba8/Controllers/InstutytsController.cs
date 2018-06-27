using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Laba8.Models;

namespace Laba8.Controllers
{
    public class InstutytsController : Controller
    {
        private LabContext db = new LabContext();

        // GET: Instutyts
        public ActionResult Index()
        {
            return View(db.Instutyts.ToList());
        }

        // GET: Instutyts/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instutyt instutyt = db.Instutyts.Find(id);
            if (instutyt == null)
            {
                return HttpNotFound();
            }
            return View(instutyt);
        }

        // GET: Instutyts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Instutyts/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Instytyts_id,Instytyts_name,Director")] Instutyt instutyt)
        {
            if (ModelState.IsValid)
            {
                db.Instutyts.Add(instutyt);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(instutyt);
        }

        // GET: Instutyts/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instutyt instutyt = db.Instutyts.Find(id);
            if (instutyt == null)
            {
                return HttpNotFound();
            }
            return View(instutyt);
        }

        // POST: Instutyts/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Instytyts_id,Instytyts_name,Director")] Instutyt instutyt)
        {
            if (ModelState.IsValid)
            {
                db.Entry(instutyt).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(instutyt);
        }

        // GET: Instutyts/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Instutyt instutyt = db.Instutyts.Find(id);
            if (instutyt == null)
            {
                return HttpNotFound();
            }
            return View(instutyt);
        }

        // POST: Instutyts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Instutyt instutyt = db.Instutyts.Find(id);
            db.Instutyts.Remove(instutyt);
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
