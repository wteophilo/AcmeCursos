using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AcmeCursos.Controllers
{
    public class ProfessorController : Controller
    {
        ProfessorRemoto.IProfessorService service = new ProfessorRemoto.ProfessorServiceClient();
        // GET: Professores
        public ActionResult Index()
        {
            return View(service.lista());
        }

        // GET: Professores/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            ProfessorRemoto.Professor professor = service.procura(id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        // GET: Professores/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Professores/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nome,sobrenome,titulacao,cursoId")] ProfessorRemoto.Professor professor)
        {
            if (ModelState.IsValid)
            {
                service.adiciona(professor);
                return RedirectToAction("Index");
            }

            return View(professor);
        }

        // GET: Professores/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfessorRemoto.Professor professor = service.procura(id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        // POST: Professores/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nome,sobrenome,titulacao,cursoId")] ProfessorRemoto.Professor professor)
        {
            if (ModelState.IsValid)
            {
                service.atualiza(professor);
                return RedirectToAction("Index");
            }
            return View(professor);
        }

        // GET: Professores/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ProfessorRemoto.Professor professor = service.procura(id);
            if (professor == null)
            {
                return HttpNotFound();
            }
            return View(professor);
        }

        // POST: Professores/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ProfessorRemoto.Professor professor = service.procura(id);
            service.remove(professor);
            return RedirectToAction("Index");
        }
    }
}