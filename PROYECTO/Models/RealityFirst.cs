
namespace PROYECTO.Models
{
    public class RealityFirst
    {
        public int IdArtista;
        public String Artista;
        public String lugar_nacimiento;
        public String fechaNac;
        public int edad;
        public String genero;

        public int IdEvento;
        public String evento;
        public String lugar;
        public String fechaEvento;
        public String tipoEvento;

        public int IdNoticia;
        public String titulo;
        public String subTitulo;
        public String autor;
        public String fechaPublicacion;
        public String noticia;

        public int Idticket;
        public String tipo;
        public String espacio;
        public int precio;

        public int IdArtista1 { get => IdArtista; set => IdArtista = value; }
        public string Artista1 { get => Artista; set => Artista = value; }
        public string Lugar_nacimiento { get => lugar_nacimiento; set => lugar_nacimiento = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }
        public int IdEvento1 { get => IdEvento; set => IdEvento = value; }
        public string Evento { get => evento; set => evento = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public string FechaEvento { get => fechaEvento; set => fechaEvento = value; }
        public string TipoEvento { get => tipoEvento; set => tipoEvento = value; }
        public int IdNoticia1 { get => IdNoticia; set => IdNoticia = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string SubTitulo { get => subTitulo; set => subTitulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        public string Noticia { get => noticia; set => noticia = value; }
        public int Idticket1 { get => Idticket; set => Idticket = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Espacio { get => espacio; set => espacio = value; }
        public int Precio { get => precio; set => precio = value; }

        public RealityFirst()
        {

        }
    }
}
