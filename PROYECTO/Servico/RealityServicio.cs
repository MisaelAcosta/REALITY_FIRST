using Microsoft.Data.SqlClient;
using PROYECTO.Models;
using PROYECTO.Servico.Contrato;
using System.Data.SqlTypes;


namespace PROYECTO.Servico
{
    public class RealityServicio : IServicio<RealityFirst>
    {
        private string Connection;

        public RealityServicio(String ConnectionString)
        {
            this.Connection = ConnectionString;
        }
        public void Create(RealityFirst obj)
        {

        }
        public void Delete(int id)
        {

        }
        public RealityFirst GetArtista(int id)
        {
            RealityFirst RFirst = new RealityFirst();   
            using (SqlConnection server=new SqlConnection(Connection))
            {
                server.Open();

                string query = string.Format("Select * from Arista;");
                using (SqlCommand cmd = new SqlCommand(query, server)) 
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            RFirst = new RealityFirst()
                            {
                                IdArtista1 = reader.GetInt32(0),
                                Artista1 = reader.GetString(1),
                                Lugar_nacimiento = reader.GetString(2),
                                FechaNac = reader.GetString(3),
                                Edad = reader.GetInt32(4),
                                Genero = reader.GetString(5),
                            };
                        }
                }
                server.Close();
            }
            return RFirst;  
            

        }

        public IList<RealityFirst> GetAll()
        {
            IList<RealityFirst> listaArtista = new List<RealityFirst>();
            using(SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("select * from artista;");
                using(SqlCommand cmd = new SqlCommand(query, server))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listaArtista.Add(new RealityFirst()
                        {
                            IdArtista = reader.GetInt32(0),
                            Artista = reader.GetString(1),
                            Lugar_nacimiento = reader.GetString(2),
                            fechaNac = reader.GetString(3),
                            edad = reader.GetInt32(4),
                            genero = reader.GetString(5)
                        });
                    }
                }
                server.Close();

            }

            return listaArtista;
        }

       

        public void Update(RealityFirst obj)
        {
            
        }

        public RealityFirst Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}
