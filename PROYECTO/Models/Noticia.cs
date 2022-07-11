using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace PROYECTO.Models
{
    public class Noticia
    {
        

        public int IdNoticia { get; set; }
        public string Titulo { get; set; }
        public string SubTitulo { get; set; }
        public string Autor { get; set; }
        public string FechaPublicacion { get; set; }
        public string Contenido { get; set; }


        public Noticia()
        {
        }
    }
}
