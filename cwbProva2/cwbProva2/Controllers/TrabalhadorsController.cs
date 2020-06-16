using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using cwbProva2.Models;

namespace cwbProva2.Controllers
{
    public class TrabalhadorsController : Controller
    {
        private Context db = new Context();

        // GET: Trabalhadors
        public ActionResult Index()
        {
            return View(db.Trabalhadores.ToList());
        }

        // GET: Trabalhadors/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabalhador trabalhador = db.Trabalhadores.Find(id);
            if (trabalhador == null)
            {
                return HttpNotFound();
            }
            return View(trabalhador);
        }

        // GET: Trabalhadors/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Trabalhadors/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Nome,Sexo,Endereco,Email,DataNascimento,CarteraTrabalho,Fonefixo,FoneCelular")] Trabalhador trabalhador)
        {
            if (ModelState.IsValid)
            {
                db.Trabalhadores.Add(trabalhador);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(trabalhador);
        }

        // GET: Trabalhadors/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabalhador trabalhador = db.Trabalhadores.Find(id);
            if (trabalhador == null)
            {
                return HttpNotFound();
            }
            return View(trabalhador);
        }

        // POST: Trabalhadors/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Nome,Sexo,Endereco,Email,DataNascimento,CarteraTrabalho,Fonefixo,FoneCelular")] Trabalhador trabalhador)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trabalhador).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(trabalhador);
        }

        // GET: Trabalhadors/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trabalhador trabalhador = db.Trabalhadores.Find(id);
            if (trabalhador == null)
            {
                return HttpNotFound();
            }
            return View(trabalhador);
        }

        // POST: Trabalhadors/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Trabalhador trabalhador = db.Trabalhadores.Find(id);
            db.Trabalhadores.Remove(trabalhador);
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
