using Microsoft.AspNetCore.Mvc;
using SLNListaDB.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SLNListaDB.Controllers
{
    public class ResponsavelController : Controller
    {
        public IActionResult Index()
        {
            ResponsavelDAO dados = new ResponsavelDAO();
            ViewBag.listaResponsavel = dados.getTodaOsResponsavel();
            return View();
        }
    }
}
