using Exemplo2.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Exemplo2.MVC.Controllers
{
    public class CervejaController : Controller
    {
        [HttpGet]
        public ActionResult Cadastrar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Salvar(Cerveja cerveja)
        {
            ViewBag.nomeCerveja = cerveja.Nome;
            ViewBag.validadeCerveja = cerveja.Validade;
            ViewBag.teorCerveja = cerveja.Teor;
            
            TempData["msg"] = "Cerveja cadastrada!";

            return View(cerveja);

            // return Content("A cerveja " + cerveja.Nome + " com teor alcoolico " + cerveja.Teor + " e validade até " + cerveja.Validar + " foi cadastrada com sucesso!");

        }
    }
}