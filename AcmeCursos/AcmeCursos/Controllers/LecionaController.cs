using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcmeCursos.Controllers
{
    public class LecionaController : Controller
    {

        private ProfessorRemoto.IProfessorService professorService = new ProfessorRemoto.ProfessorServiceClient();
        private CursoRemoto.ICursoService cursoService = new CursoRemoto.CursoServiceClient();
        private LecionaRemoto.IProfessorCursoService insService = new LecionaRemoto.ProfessorCursoServiceClient();

        public ActionResult cadastrarAula()
        {
            var professores = professorService.lista();
            var cursos = cursoService.lista();

            List<SelectListItem> selectProfessores = professores.Select(e => new SelectListItem()
            {
                Text = string.Format("{0} {1}", e.nome, e.sobrenome),
                Value = e.id.ToString()
            }).ToList();

            List<SelectListItem> selectCursos = cursos.Select(c => new SelectListItem()
            {
                Text = c.nome,
                Value = c.id.ToString()
            }).ToList();

            ViewBag.professorId = selectProfessores;
            ViewBag.cursoId = selectCursos;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult cadastrarAula(LecionaRemoto.ProfessorCurso leciona)
        {
            if (ModelState.IsValid)
            {
                insService.adiciona(leciona);
                ViewBag.Messagem = "Curso associado com sucesso!";
                return View("Sucesso");
            }
            return View();
        }
    }
}