using PROYECTO.Models;
using System.Linq;
using System.Threading.Tasks;

namespace PROYECTO.Servicio
{
    public class pruebaServicio :IServicio<Artista>
    {
        IList<Artista> lista = new List<Artista>();

        public pruebaServicio()
        {
            lista = new List<Artista>
            {
                new Artista
                {
                    IdArtista = 1,
                    Nombre = "Pikachu",
                    Edad = 42,
                    Genero = "metal"
                },
                new Artista
                {
                    IdArtista = 2,
                    Nombre = "alan",
                    Edad = 33,
                    Genero = "metal"
                },
                new Artista
                {
                    IdArtista = 3,
                    Nombre = "computador",
                    Edad = 13,
                    Genero = "pop"
                },
                new Artista
                {
                   IdArtista = 4,
                    Nombre = "nuevo",
                    Edad = 60,
                    Genero = "metal"
                },
            };
        }

        public pruebaServicio(string connectionString)
        {
        }

        public void Create(Artista obj)
        {
            lista.Add(obj);
        }

        public void Delete(int id)
        {
            Artista obj = lista.FirstOrDefault(x => x.IdArtista == id);
            if (obj != null)
            {
                lista.Remove(obj);
            }
        }

        public Artista Get(int id)
        {
            Artista obj = lista.FirstOrDefault(x => x.IdArtista == id);
            return obj;
        }

        public IList<Artista> GetAll()
        {
            return lista;
        }

        public void Update(Artista obj)
        {
            Artista pokemon = lista.FirstOrDefault(x => x.IdArtista == obj.IdArtista);

            pokemon = new Artista
            {
                Nombre = obj.Nombre,
                Edad = obj.Edad,
                Genero = obj.Genero
            };
        }
    }

}
