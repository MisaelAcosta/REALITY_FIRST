using Microsoft.AspNetCore.Mvc;
using PROYECTO.Models;
using PROYECTO.Servico;
using System.Diagnostics;

namespace PROYECTO.Controllers
{
    public class RealityFirstController : Controller
    {
        IConfiguration config;
        ArtistaServicio app;
        NoticiaServicio NS;
        

        public RealityFirstController(IConfiguration config)
        {
            this.config = config;
            string ConnectionString = config.GetConnectionString("DBDRealityFirst");

            app = new ArtistaServicio(ConnectionString);
        }

        public IActionResult Entradas()
        {

            return View();
        }
        public IActionResult PruebasAntesDe(int id)
        {
            ModeloArtista obj = app.GetArtista(id);

            return View("Artistas", obj);
        }
        public IActionResult Contacto()
        {
            return View();
        }
        public IActionResult Noticias(int id)
        {
            modeloNoticia obj = NS.Get(id);
            return View("Noticias",obj);
        }
        public IActionResult Artistas()
        {
            IList<ModeloArtista> listaArtista = app.GetAll();    

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
