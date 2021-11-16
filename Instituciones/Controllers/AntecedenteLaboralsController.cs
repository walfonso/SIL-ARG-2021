using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Instituciones.Models;

namespace Instituciones.Controllers
{
    public class AntecedenteLaboralsController : Controller
    {
        private Empleo db = new Empleo();

        // GET: AntecedenteLaborals
        public ActionResult Index()
        {
            return View(db.AntecedentesLaborales.ToList());
        }

        // GET: AntecedenteLaborals/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AntecedenteLaboral antecedenteLaboral = db.AntecedentesLaborales.Find(id);
            if (antecedenteLaboral == null)
            {
                return HttpNotFound();
            }
            return View(antecedenteLaboral);
        }

        // GET: AntecedenteLaborals/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: AntecedenteLaborals/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idAntLaboral")] AntecedenteLaboral antecedenteLaboral)
        {
            if (ModelState.IsValid)
            {
                db.AntecedentesLaborales.Add(antecedenteLaboral);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(antecedenteLaboral);
        }

        // GET: AntecedenteLaborals/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AntecedenteLaboral antecedenteLaboral = db.AntecedentesLaborales.Find(id);
            if (antecedenteLaboral == null)
            {
                return HttpNotFound();
            }
            return View(antecedenteLaboral);
        }

        // POST: AntecedenteLaborals/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idAntLaboral")] AntecedenteLaboral antecedenteLaboral)
        {
            if (ModelState.IsValid)
            {
                db.Entry(antecedenteLaboral).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(antecedenteLaboral);
        }

        // GET: AntecedenteLaborals/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AntecedenteLaboral antecedenteLaboral = db.AntecedentesLaborales.Find(id);
            if (antecedenteLaboral == null)
            {
                return HttpNotFound();
            }
            return View(antecedenteLaboral);
        }

        // POST: AntecedenteLaborals/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AntecedenteLaboral antecedenteLaboral = db.AntecedentesLaborales.Find(id);
            db.AntecedentesLaborales.Remove(antecedenteLaboral);
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
