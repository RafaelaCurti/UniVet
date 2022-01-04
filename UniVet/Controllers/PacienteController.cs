using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UniVet.Controllers
{
    public class PacienteController : Controller
    {
        // GET: Veterinario
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Cadastrar()
        {
            return View();
        } 

        [HttpPost]
        public ActionResult Cadastrar(int id)
        {
            return View();
        }
        public ActionResult Editar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Editar(int id)
        {
            return View();
        }
        public ActionResult Excluir()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Excluir(int id)
        {
            return View();
        }
    }
}