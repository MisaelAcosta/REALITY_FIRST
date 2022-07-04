
namespace PROYECTO.Models
{
    public class ModeloArtista
    {
        private int idArtista;
        private string artista;
        private string lugar_nacimiento;
        private string fechaNac;
        private int edad;
        private string genero;

       
  
        public int IdArtista { get => idArtista; set => idArtista = value; }
        public string Artista { get => artista; set => artista = value; }
        public string Lugar_nacimiento { get => lugar_nacimiento; set => lugar_nacimiento = value; }
        public string FechaNac { get => fechaNac; set => fechaNac = value; }
        public int Edad { get => edad; set => edad = value; }
        public string Genero { get => genero; set => genero = value; }

        public ModeloArtista()
        {

        }
    }
}
