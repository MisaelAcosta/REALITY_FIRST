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
        EventoServicio ES;


#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public RealityFirstController(IConfiguration config)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
            this.config = config;
            string ConnectionString = config.GetConnectionString("DBDRealityFirst");

            app = new ArtistaServicio(ConnectionString);
            NS = new NoticiaServicio(ConnectionString);
            ES = new EventoServicio(ConnectionString);
        }

        public IActionResult Entradas()
        {

            return View();
        }
        public IActionResult PruebasAntesDe()
        {
            IList<ModeloArtista> ListaArtista = app.GetAll();

            return View("Pruebas", ListaArtista);
        }
        public IActionResult Contacto()
        {
            return View();
        }
        public IActionResult Noticias()
        {

           IList<ModeloNoticia> ListaNoticia = NS.GetAll();
            return View("Noticias", ListaNoticia);
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
