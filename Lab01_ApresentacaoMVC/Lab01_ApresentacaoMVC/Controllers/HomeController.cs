using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab01_ApresentacaoMVC.Models;

namespace Lab01_ApresentacaoMVC.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            ViewBag.Agora = "Hello MVC! " + DateTime.Now;
            return View();
        }
        //public string Index()
        //{
        //    return "Hello MVC!";
        //}
        public ActionResult Filme()
        {
            Filme filme = new Filme()
            {
                Titulo = "Inglourious Basterds",
                Genero = "War",
                Assistido = true
            };
            return View(filme);
        }

        [HttpPost]
        public ActionResult Filme(Filme f)
        {
            // verifica se o modelo está correto
            if (ModelState.IsValid)
            {
                return View("Listagem", f);
            }
            return View(f);
        }
        public ActionResult Listagem(Filme f)
        {
            return View(f);
        }
        public ActionResult Index2()
        {
            ViewBag.Agora = "MVC maluco! " + DateTime.Now;
            return View();
        }
    }
}