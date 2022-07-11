using Microsoft.AspNetCore.Mvc;
using PROYECTO.Models;
using PROYECTO.Servico;
using System.Diagnostics;

namespace PROYECTO.Controllers
{
    public class RealityFirstController : Controller
    {
        IConfiguration config;
        ArtistaServicio AS;
        NoticiaServicio NS;
        EventoServicio ES;
        TicketServicio TicketS;


#pragma warning disable CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        public RealityFirstController(IConfiguration config)
#pragma warning restore CS8618 // Un campo que no acepta valores NULL debe contener un valor distinto de NULL al salir del constructor. Considere la posibilidad de declararlo como que admite un valor NULL.
        {
            this.config = config;
            string ConnectionString = config.GetConnectionString("DBDRealityFirst");

            AS = new ArtistaServicio(ConnectionString);
            NS = new NoticiaServicio(ConnectionString);
            ES = new EventoServicio(ConnectionString);
            TicketS = new TicketServicio(ConnectionString);
        }

        public IActionResult Entradas(int id, object ticketServicio)
        {
            return View(ticketServicio);
        }
        public IActionResult PruebasAntesDe()
        {
            IList<ModeloArtista> ListaArtista = AS.GetAll();

            return View(ListaArtista);
        }
        public IActionResult Contacto()
        {
            return View();
        }
        public IActionResult Noticias()
        {

           IList<ModeloNoticia> ListaNoticia = NS.GetAll();
            return View(ListaNoticia);
        }
        public IActionResult Artistas()
        {
            IList<ModeloArtista> listaArtista = AS.GetAll();    

            return View(listaArtista);
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
