using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Aircraft.DA;
using Aircraft.Models;

namespace Aircraft.Controllers
{
    public class AerolineasController : Controller
    {
        private AircraftContext db = new AircraftContext();

        // GET: Aerolineas
        public ActionResult Index()
        {
            return View(db.Aereolinea.ToList());
        }

        // GET: Aerolineas/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aerolinea aerolinea = db.Aereolinea.Find(id);
            if (aerolinea == null)
            {
                return HttpNotFound();
            }
            return View(aerolinea);
        }

        // GET: Aerolineas/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Aerolineas/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "AerolineaID,Nombre")] Aerolinea aerolinea)
        {
            if (ModelState.IsValid)
            {
                db.Aereolinea.Add(aerolinea);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(aerolinea);
        }

        // GET: Aerolineas/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aerolinea aerolinea = db.Aereolinea.Find(id);
            if (aerolinea == null)
            {
                return HttpNotFound();
            }
            return View(aerolinea);
        }

        // POST: Aerolineas/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "AerolineaID,Nombre")] Aerolinea aerolinea)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aerolinea).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(aerolinea);
        }

        // GET: Aerolineas/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Aerolinea aerolinea = db.Aereolinea.Find(id);
            if (aerolinea == null)
            {
                return HttpNotFound();
            }
            return View(aerolinea);
        }

        // POST: Aerolineas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Aerolinea aerolinea = db.Aereolinea.Find(id);
            db.Aereolinea.Remove(aerolinea);
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
