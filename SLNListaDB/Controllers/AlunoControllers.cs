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
        public IActionResult Index()
        {
            AlunoDAO dados = new AlunoDAO();
            ViewBag.listaAluno = dados.getTodoOsAlunos();
            return View();
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
    }
}
