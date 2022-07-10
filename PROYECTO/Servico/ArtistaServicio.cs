using Microsoft.Data.SqlClient;
using PROYECTO.Models;
using PROYECTO.Servico.Contrato;


namespace PROYECTO.Servico
{
    public class ArtistaServicio : IServicio<ModeloArtista>
    {
        private string Connection;

        public ArtistaServicio(String ConnectionString)
        {
            this.Connection = ConnectionString;
        }
        public void Create(ModeloArtista obj)
        {
            ModeloArtista MArtista = new ModeloArtista ();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("insert into dbo.Artista values (" + obj.IdArtista + ",'" + obj.Artista+"','"+obj.Lugar_nacimiento+"','"+obj.FechaNac+"',"+obj.Edad+",'"+obj.Genero+"');");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MArtista = new ModeloArtista()
                            {
                                IdArtista = reader.GetInt32(0),
                                Artista = reader.GetString(1),
                                Lugar_nacimiento = reader.GetString(2),
                                FechaNac = reader.GetString(3),
                                Edad = reader.GetInt32(4),
                                Genero = reader.GetString(5)
                            };
                        }
                    }
                }
                server.Close();
            }
        }
        public void Delete(int id)
        {
            ModeloArtista MArtista = new ModeloArtista();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("delete from dbo.artista where IdArtista = "+id);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MArtista = new ModeloArtista()
                            {
                                IdArtista = reader.GetInt32(0),
                                Artista = reader.GetString(1),
                                Lugar_nacimiento = reader.GetString(2),
                                FechaNac = reader.GetString(3),
                                Edad = reader.GetInt32(4),
                                Genero = reader.GetString(5)
                            };
                        }
                    }
                }
                server.Close();
            }
        }
        
        public IList<ModeloArtista> GetAll()
        {
            IList<ModeloArtista> listaArtista = new List<ModeloArtista>();
            using(SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("select * from dbo.artista;");
                using(SqlCommand cmd = new SqlCommand(query, server))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listaArtista.Add(new ModeloArtista()
                        {
                            IdArtista = reader.GetInt32(0),
                            Artista = reader.GetString(1),
                            Lugar_nacimiento = reader.GetString(2),
                            FechaNac = reader.GetString(3),
                            Edad = reader.GetInt32(4),
                            Genero = reader.GetString(5)
                        });
                    }
                }
                server.Close();

            }

            return listaArtista;
        }

       
        public void Update(ModeloArtista obj)
        {
            ModeloArtista MArtista = new ModeloArtista();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("update dbo.Artista set Artista="+obj.Artista+" where IdArtista = " + obj.IdArtista);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MArtista = new ModeloArtista()
                            {
                                IdArtista = reader.GetInt32(0),
                                Artista = reader.GetString(1),
                                Lugar_nacimiento = reader.GetString(2),
                                FechaNac = reader.GetString(3),
                                Edad = reader.GetInt32(4),
                                Genero = reader.GetString(5)
                            };
                        }
                    }
                }
                server.Close();
            }
        }

        public ModeloArtista Get(int id)
        {
            ModeloArtista MArtista = new ModeloArtista();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();

                string query = string.Format("Select artista from dbo.artista where IdArtista = " + id + ";");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            MArtista = new ModeloArtista()
                            {
                                IdArtista = reader.GetInt32(0),
                                Artista = reader.GetString(1),
                                Lugar_nacimiento = reader.GetString(2),
                                FechaNac = reader.GetString(3),
                                Edad = reader.GetInt32(4),
                                Genero = reader.GetString(5),
                            };
                        }
                }
                server.Close();
            }
            return MArtista;
        }
    }
}
