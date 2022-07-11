using Microsoft.Data.SqlClient;
using PROYECTO.Models;
using PROYECTO.Servicio;


namespace PROYECTO.Servicio
{
    public class ArtistaServicio : IServicio<Artista>
    {
        private string Connection;

        public ArtistaServicio(String ConnectionString)
        {
            this.Connection = ConnectionString;
        }
        public void Create(Artista obj)
        {
            Artista MArtista = new Artista ();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("insert into dbo.Artista values (" + obj.IdArtista + ",'" + obj.Nombre+"','"+obj.Lugar_nacimiento+"','"+obj.FechaNac+"',"+obj.Edad+",'"+obj.Genero+"');");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MArtista = new Artista()
                            {
                                IdArtista = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
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
            Artista MArtista = new Artista();
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
                            MArtista = new Artista()
                            {
                                IdArtista = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
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
        
        public IList<Artista> GetAll()
        {
            IList<Artista> listaArtista = new List<Artista>();
            using(SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("select * from dbo.artista;");
                using(SqlCommand cmd = new SqlCommand(query, server))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                        listaArtista.Add(new Artista()
                        {
                            IdArtista = reader.GetInt32(0),
                            Nombre = reader.GetString(1),
                            Lugar_nacimiento = reader.GetString(2),
                            FechaNac = reader.GetString(3),
                            Edad = reader.GetInt32(4),
                            Genero = reader.GetString(5)
                        });
                        }
                    }
                }
                server.Close();

            }

            return listaArtista;
        }

       
        public void Update(Artista obj)
        {
            Artista MArtista = new Artista();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("update dbo.Artista set Artista="+obj.Nombre + " where IdArtista = " + obj.IdArtista);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MArtista = new Artista()
                            {
                                IdArtista = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
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

        public Artista Get(int id)
        {
            Artista MArtista = new Artista();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();

                string query = string.Format("Select artista from dbo.artista where IdArtista = " + id + ";");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            MArtista = new Artista()
                            {
                                IdArtista = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
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
