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
    public class Referentes1Controller : Controller
    {
        private Empleo db = new Empleo();

        // GET: Referentes
        public ActionResult Index()
        {
            return View(db.Personas.ToList());
        }

        // GET: Referentes/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Referente referente = (Referente)db.Personas.Find(id);
            if (referente == null)
            {
                return HttpNotFound();
            }
            return View(referente);
        }

        // GET: Referentes/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Referentes/Create
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "idPersona,documento,apellidos,nombres,fechaNacimiento,genero,domicilio,telefono,celular,redes,area,cargo")] Referente referente)
        {
            if (ModelState.IsValid)
            {
                db.Personas.Add(referente);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(referente);
        }

        // GET: Referentes/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Referente referente = (Referente)db.Personas.Find(id);
            if (referente == null)
            {
                return HttpNotFound();
            }
            return View(referente);
        }

        // POST: Referentes/Edit/5
        // Para protegerse de ataques de publicación excesiva, habilite las propiedades específicas a las que quiere enlazarse. Para obtener 
        // más detalles, vea https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "idPersona,documento,apellidos,nombres,fechaNacimiento,genero,domicilio,telefono,celular,redes,area,cargo")] Referente referente)
        {
            if (ModelState.IsValid)
            {
                db.Entry(referente).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(referente);
        }

        // GET: Referentes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Referente referente = (Referente)db.Personas.Find(id);
            if (referente == null)
            {
                return HttpNotFound();
            }
            return View(referente);
        }

        // POST: Referentes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Referente referente = (Referente)db.Personas.Find(id);
            db.Personas.Remove(referente);
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
