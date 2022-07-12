using Microsoft.AspNetCore.Mvc;
using PROYECTO.Models;
using PROYECTO.Servicio;
using System.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace PROYECTO.Controllers
{
    public class RealityFirstController : Controller
    {
        
        
        IConfiguration config;
        ArtistaServicio aServicio;
        NoticiaServicio nServicio;
        //  EventoServicio eServicio;
        TicketServicio tServicio;
        pruebaServicio pServicio;

        //private readonly ILogger<RealityFirstController> _logger;

        //public RealityFirstController(ILogger<RealityFirstController> logger)
        //{
        //    _logger = logger;
        //}
        public RealityFirstController(IConfiguration config)
        {
            this.config = config;
            string ConnectionString = config.GetConnectionString("dbRealityFirst");

            aServicio = new ArtistaServicio(ConnectionString);
            nServicio = new NoticiaServicio(ConnectionString);
            pServicio = new pruebaServicio(ConnectionString);
            //    eServicio = new EventoServicio(ConnectionString);
            tServicio = new TicketServicio(ConnectionString);
        }

        

        public IActionResult Entradas(int id)
        {
            //Ticket obj = tServicio.Get(id);
            return View();

        }

        public IActionResult PruebasAntesDe()
        {
            IList<Artista> listaArtista = pServicio.GetAll();

            return View("PruebasAntesDe",listaArtista);
        }
        public IActionResult Contacto()
        {
            return View();
        }
        public IActionResult Noticias()
        {

            //IList<Noticia> ListaNoticia = nServicio.GetAll();
            return View();
        }
        public IActionResult Artistas()
        {
            //IList<Artista> listaArtista = aServicio.GetAll();

            return View();
        }
        public IActionResult Pago()
        {
            return View();
        }
        public IActionResult Index()
        {
            return View();
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
