using Microsoft.AspNetCore.Mvc;
using PROYECTO.Models;
using System.Diagnostics;

namespace Pruebas.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Noticias()
        {
            return View();
        }
        public IActionResult Ingresar()
        {
            return View();
        }

        public IActionResult Contacto()
        {
            return View();
        }
        public IActionResult Entradas()
        {
            return View();
        }
        public IActionResult PruebasAntesDe()
        {
            
            return View();
        }

        public IActionResult Artistas()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}