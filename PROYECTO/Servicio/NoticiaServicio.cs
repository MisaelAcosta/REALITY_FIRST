using Microsoft.Data.SqlClient;
using PROYECTO.Models;
using PROYECTO.Servicio;



namespace PROYECTO.Servicio
{
    public class NoticiaServicio : IServicio<Noticia>
    {
        private string Connection;

        public NoticiaServicio(String ConnectionString)
        {
            this.Connection = ConnectionString;
        }

        public void  Create(Noticia obj)
        {
            Noticia MNoticia = new Noticia();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("insert into dbo.noticia values("+obj.IdNoticia+",'"
                                             +obj.Titulo+"','"+obj.SubTitulo+"','"+obj.Autor+"','"
                                             +obj.FechaPublicacion+"','"+obj.Contenido+"');");
                using(SqlCommand cmd = new SqlCommand(query, server))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MNoticia = new Noticia()
                            {
                                IdNoticia = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                SubTitulo = reader.GetString(2),
                                Autor = reader.GetString(3),
                                FechaPublicacion = reader.GetString(4),
                                Contenido = reader.GetString(5)
                            };
                        }
                    }
                }
                server.Close();
            }
        }

       public  void  Delete(int id)
        {
            Noticia MNoticia = new Noticia();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("delete from dbo.noticia where idNoticia="+id+";");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MNoticia = new Noticia()
                            {
                                IdNoticia = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                SubTitulo = reader.GetString(2),
                                Autor = reader.GetString(3),
                                FechaPublicacion = reader.GetString(4),
                                Contenido = reader.GetString(5)
                            };
                        }
                    }
                }
                server.Close();
            }
        }
    

        public Noticia Get(int id)
        {
            Noticia MNoticia = new Noticia();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("select * from dbo.noticia where idNoticia="+id+";");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MNoticia = new Noticia()
                            {
                                IdNoticia = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                SubTitulo = reader.GetString(2),
                                Autor = reader.GetString(3),
                                FechaPublicacion = reader.GetString(4),
                                Contenido = reader.GetString(5)
                            };
                        }
                    }
                }
                server.Close();
            }
            return MNoticia;
        }
    

        public IList<Noticia> GetAll()
        {
            IList<Noticia> listaNoticia = new List<Noticia>();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("select * from dbo.noticia;");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            listaNoticia.Add(new Noticia()
                            {
                                IdNoticia = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                SubTitulo = reader.GetString(2),
                                Autor = reader.GetString(3),
                                FechaPublicacion = reader.GetString(4),
                                Contenido = reader.GetString(5)
                            });
                        }
                    }
                }
                server.Close();
            }
            return listaNoticia;
        }
    

        public void  Update(Noticia obj)
        {
            Noticia MNoticia = new Noticia();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("update from dbo.noticia set="+obj.Contenido + "where IdNoticia="+obj.IdNoticia);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MNoticia = new Noticia()
                            {
                                IdNoticia = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                SubTitulo = reader.GetString(2),
                                Autor = reader.GetString(3),
                                FechaPublicacion = reader.GetString(4),
                                Contenido = reader.GetString(5)
                            };
                        }
                    }
                }
                server.Close();
            }
        }
    }
    
}
