using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECTO.Models
{
    public class Ticket
    {
        

        public int Idticket { get; set; }
        public string Tipo { get; set; }
        public string Espacio { get; set; }
        public int Precio { get; set; }
        public int IdArtista { get; set; }

        public Ticket()
        {

        }
    }
}
