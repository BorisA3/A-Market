using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using A_Market.Data;
using A_Market.Models;

namespace A_Market.Controllers
{
    public class IdentificationTypesController : Controller
    {
        private A_MarketContext db = new A_MarketContext();

        // GET: IdentificationTypes
        public ActionResult Index()
        {
            return View(db.IdentificationTypes.ToList());
        }

        // GET: IdentificationTypes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IdentificationType identificationType = db.IdentificationTypes.Find(id);
            if (identificationType == null)
            {
                return HttpNotFound();
            }
            return View(identificationType);
        }

        // GET: IdentificationTypes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: IdentificationTypes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IdentificationTypeKey,IdentificationTypeName")] IdentificationType identificationType)
        {
            if (ModelState.IsValid)
            {
                db.IdentificationTypes.Add(identificationType);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(identificationType);
        }

        // GET: IdentificationTypes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IdentificationType identificationType = db.IdentificationTypes.Find(id);
            if (identificationType == null)
            {
                return HttpNotFound();
            }
            return View(identificationType);
        }

        // POST: IdentificationTypes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que desea enlazarse. Para obtener 
        // más información vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IdentificationTypeKey,IdentificationTypeName")] IdentificationType identificationType)
        {
            if (ModelState.IsValid)
            {
                db.Entry(identificationType).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(identificationType);
        }

        // GET: IdentificationTypes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IdentificationType identificationType = db.IdentificationTypes.Find(id);
            if (identificationType == null)
            {
                return HttpNotFound();
            }
            return View(identificationType);
        }

        // POST: IdentificationTypes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            IdentificationType identificationType = db.IdentificationTypes.Find(id);
            db.IdentificationTypes.Remove(identificationType);
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
