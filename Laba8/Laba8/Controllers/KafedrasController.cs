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
    public class KafedrasController : Controller
    {
        private LabContext db = new LabContext();

        // GET: Kafedras
        public ActionResult Index()
        {
            return View(db.Kafedras.ToList());
        }

        // GET: Kafedras/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kafedra kafedra = db.Kafedras.Find(id);
            if (kafedra == null)
            {
                return HttpNotFound();
            }
            return View(kafedra);
        }

        // GET: Kafedras/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Kafedras/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Kafedra_id,Kafedra_name,Kafedra_zav,Count_Doctor_Science,Instytyts_id")] Kafedra kafedra)
        {
            if (ModelState.IsValid)
            {
                db.Kafedras.Add(kafedra);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(kafedra);
        }

        // GET: Kafedras/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kafedra kafedra = db.Kafedras.Find(id);
            if (kafedra == null)
            {
                return HttpNotFound();
            }
            return View(kafedra);
        }

        // POST: Kafedras/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Kafedra_id,Kafedra_name,Kafedra_zav,Count_Doctor_Science,Instytyts_id")] Kafedra kafedra)
        {
            if (ModelState.IsValid)
            {
                db.Entry(kafedra).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(kafedra);
        }

        // GET: Kafedras/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Kafedra kafedra = db.Kafedras.Find(id);
            if (kafedra == null)
            {
                return HttpNotFound();
            }
            return View(kafedra);
        }

        // POST: Kafedras/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Kafedra kafedra = db.Kafedras.Find(id);
            db.Kafedras.Remove(kafedra);
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
