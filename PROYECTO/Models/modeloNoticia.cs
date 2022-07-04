namespace PROYECTO.Models
{
    public class ModeloNoticia
    {
        private int idNoticia;
        private string titulo;
        private string subTitulo;
        private string autor;
        private string fechaPublicacion;
        private string noticia;

        public int IdNoticia { get => idNoticia; set => idNoticia = value; }
        public string Titulo { get => titulo; set => titulo = value; }
        public string SubTitulo { get => subTitulo; set => subTitulo = value; }
        public string Autor { get => autor; set => autor = value; }
        public string FechaPublicacion { get => fechaPublicacion; set => fechaPublicacion = value; }
        public string Noticia { get => noticia; set => noticia = value; }


        public ModeloNoticia()
        {
        }
    }
}
