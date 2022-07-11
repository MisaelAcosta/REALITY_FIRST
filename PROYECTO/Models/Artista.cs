using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PROYECTO.Models
{
    public class Artista
    {
        public int IdArtista { get ; set ; }
        public string Nombre { get ; set; }
        public string Lugar_nacimiento { get; set; }
        public string FechaNac { get; set; }
        public int Edad { get; set; }
        public string Genero { get; set; }

        public Artista()
        {

        }
    }
}
