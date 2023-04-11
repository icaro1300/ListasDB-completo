using Microsoft.AspNetCore.Mvc;
using SLNListaDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.Controllers
{
    public class AlunoControllers : Controller
    {
        AlunoDAO tbAluno = new AlunoDAO();
        public IActionResult Index()
        {
            ViewBag.listaAluno = tbAluno.getTodaOsAlunos();
            return View();
        }
    }
}
