using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AcmeCursos.Controllers
{
    public class InscricaoController : Controller
    {
        private EstudanteRemoto.IEstudanteService estudanteService = new EstudanteRemoto.EstudanteServiceClient();
        private CursoRemoto.ICursoService cursoService = new CursoRemoto.CursoServiceClient();
        private InscricaoRemoto.IInscricaoService insService = new InscricaoRemoto.InscricaoServiceClient();

        public ActionResult cadastrarEstudante()
        {
            var estudantes = estudanteService.listaEstudante();
            var cursos = cursoService.lista();

        List<SelectListItem> selectEstudantes = estudantes.Select(e => new SelectListItem()
        {
            Text = string.Format("{0} {1}", e.nome, e.sobrenome),
            Value = e.id.ToString()
        }).ToList();

        List<SelectListItem> selecrCusos = cursos.Select(c => new SelectListItem()
        {
            Text = c.nome,
            Value = c.id.ToString()
        }).ToList();

        ViewBag.estudanteId = selectEstudantes;
        ViewBag.cursosId = selecrCusos;

        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public ActionResult cadastrarEstudante(InscricaoRemoto.Inscricao inscricao)
    {
        if (ModelState.IsValid)
        {
            inscricao.dataInscricao = DateTime.Now;
            insService.adiciona(inscricao);
            ViewBag.Messagem = "Estudante cadastrado com sucesso!";
            return View("Sucesso");
        }
        return View();
    }
}
}