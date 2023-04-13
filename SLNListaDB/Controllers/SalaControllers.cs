using Microsoft.AspNetCore.Mvc;
using SLNListaDB.DAL;
using SLNListaDB.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.Controllers
{
    public class SalaControllers : Controller
    {
        SalaDAO tbSala = new SalaDAO();

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.listasSalas = tbSala.getTodaAsSalas();
            return View();
        }

        [HttpPost]
        public IActionResult Create(string descricao)
        {
            Sala novaSala = new Sala();
            novaSala.SalaDescricao = descricao;
            tbSala.insertSala(novaSala);

            return RedirectToAction("Index");
        }
    }
}