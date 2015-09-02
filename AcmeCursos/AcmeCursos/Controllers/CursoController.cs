using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace AcmeCursos.Controllers
{
    public class CursoController : Controller
    {
        private CursoRemoto.ICursoService service = new CursoRemoto.CursoServiceClient();

        // GET: Curso
        public ActionResult Index()
        {
            var lista = service.lista();
            return View(lista);
        }

        // GET: Curso/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CursoRemoto.Curso curso = service.detalhe(id);
            if (curso == null)
            {
                return HttpNotFound();
            }
            return View(curso);
        }

        // GET: Curso/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Curso/Create
        [HttpPost]
        public ActionResult Create(CursoRemoto.Curso curso)
        {
            if (ModelState.IsValid)
            {
                service.adiciona(curso);
                return RedirectToAction("Index");
            }

            return View(curso);
        }

        // GET: Curso/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CursoRemoto.Curso cursos =service.procura(id);
            if (cursos == null)
            {
                return HttpNotFound();
            }
            return View(cursos);
        }

        // POST: Curso/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, CursoRemoto.Curso curso)
        {
            if (ModelState.IsValid)
            {
                service.atualiza(curso);
                return RedirectToAction("Index");
            }
            return View(curso);
        }

        // GET: Curso/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CursoRemoto.Curso cursos = service.procura(id);
            if (cursos == null)
            {
                return HttpNotFound();
            }
            return View(cursos);
        }

              // POST: Estudantes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            CursoRemoto.Curso curso = service.procura(id);
            service.remove(curso);
            return RedirectToAction("Index");
        }
    }
}
