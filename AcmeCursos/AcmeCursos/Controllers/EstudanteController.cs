using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AcmeCursos.Controllers
{
    public class EstudanteController : Controller
    {
        private EstudanteRemoto.IEstudanteService service = new EstudanteRemoto.EstudanteServiceClient();
        // GET: Estudante
        public ActionResult Index()
        {
            //var lista = service.listaEstudante();
            return View();
        }

        // GET: Estudante/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            EstudanteRemoto.Estudante estudante = service.detalhe(id);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        // GET: Estudante/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Estudante/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(EstudanteRemoto.Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                service.adiciona(estudante);
                return RedirectToAction("Index");
            }

            return View(estudante);
        }

        // GET: Estudante/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Estudante/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, EstudanteRemoto.Estudante estudante)
        {
            if (ModelState.IsValid)
            {
                service.atualiza(estudante);
                return RedirectToAction("Index");
            }
            return View(estudante);
        }

        // GET: Estudante/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // GET: Estudantes/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //Estudante estudante = db.Estudantes.Find(id);
            EstudanteRemoto.Estudante estudante = service.procura(id);
            service.remove(estudante);
            if (estudante == null)
            {
                return HttpNotFound();
            }
            return View(estudante);
        }

        // POST: Estudantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            EstudanteRemoto.Estudante estudante = service.procura(id);
            service.remove(estudante);
            return RedirectToAction("Index");
        }
    }
}
