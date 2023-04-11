using Microsoft.AspNetCore.Mvc;
using SLNListaDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.Controllers
{
    public class SalaControllers : Controller
    {
        SalaDAO tbSala = new SalaDAO();
        public IActionResult Index()
        {
            ViewBag.listasalas = tbSala.getTodaAsSalas();
            return View();
        }
    }
}