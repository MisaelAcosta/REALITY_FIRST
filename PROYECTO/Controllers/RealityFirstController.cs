using Microsoft.AspNetCore.Mvc;
using PROYECTO.Models;
using PROYECTO.Servico;
using System.Diagnostics;

namespace PROYECTO.Controllers
{
    public class RealityFirstController : Controller
    {
        IConfiguration config;
        RealityServicio app;
        

        public RealityFirstController(IConfiguration config)
        {
            this.config = config;
            string ConnectionString = config.GetConnectionString("RealityFirst");

            app = new RealityServicio(ConnectionString);
        }

        public IActionResult Entradas()
        {

            return View();
        }
        public IActionResult Contacto()
        {
            return View();
        }
        public IActionResult Noticias()
        {
            IList<RealityFirst> listaNoticia = app.GetAllNoticia();
            return View(listaNoticia);
        }
        public IActionResult Artistas()
        {
            IList<RealityFirst> listaArtista = app.GetAll();    

            return View("Artistas",listaArtista);
        }

        public IActionResult Ingresar()
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
