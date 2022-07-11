using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECTO.Models
{
    public class Evento
    {
        

       public int IdEvento { get ; set; }
        public string Nombre { get; set; }
        public string Lugar { get; set; }
        public string FechaEvento { get; set; }
        public string TipoEvento { get; set; }
        public int IdArtista { get; set; }

        public Evento()
        {

        }

        
    }
}
