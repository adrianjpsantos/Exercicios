using Microsoft.AspNetCore.Mvc;
using Exercicios.Models;

namespace Exercicios.Controllers
{
    public class CondicionaisController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult CondicionalIf()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CondicionalIf(Partida partida)
        {
            return View(partida);
        }

        [HttpGet]
        public IActionResult CondicionalSwitch()
        {
            return View();
        }



    }
}