using Microsoft.Data.SqlClient;
using PROYECTO.Models;
using PROYECTO.Servico.Contrato;



namespace PROYECTO.Servico
{
    public class NoticiaServicio : IServicio<ModeloNoticia>
    {
        private string Connection;

        public NoticiaServicio(String ConnectionString)
        {
            this.Connection = ConnectionString;
        }

        public void  Create(ModeloNoticia obj)
        {
            ModeloNoticia MNoticia = new ModeloNoticia();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("insert into dbo.noticia values("+obj.IdNoticia+",'"
                                             +obj.Titulo+"','"+obj.SubTitulo+"','"+obj.Autor+"','"
                                             +obj.FechaPublicacion+"','"+obj.Noticia+"');");
                using(SqlCommand cmd = new SqlCommand(query, server))
                {
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MNoticia = new ModeloNoticia()
                            {
                                IdNoticia = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                SubTitulo = reader.GetString(2),
                                Autor = reader.GetString(3),
                                FechaPublicacion = reader.GetString(4),
                                Noticia = reader.GetString(5)
                            };
                        }
                    }
                }
                server.Close();
            }
        }

       public  void  Delete(int id)
        {
            ModeloNoticia MNoticia = new ModeloNoticia();
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
                            MNoticia = new ModeloNoticia()
                            {
                                IdNoticia = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                SubTitulo = reader.GetString(2),
                                Autor = reader.GetString(3),
                                FechaPublicacion = reader.GetString(4),
                                Noticia = reader.GetString(5)
                            };
                        }
                    }
                }
                server.Close();
            }
        }
    

        public ModeloNoticia Get(int id)
        {
            ModeloNoticia MNoticia = new ModeloNoticia();
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
                            MNoticia = new ModeloNoticia()
                            {
                                IdNoticia = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                SubTitulo = reader.GetString(2),
                                Autor = reader.GetString(3),
                                FechaPublicacion = reader.GetString(4),
                                Noticia = reader.GetString(5)
                            };
                        }
                    }
                }
                server.Close();
            }
            return MNoticia;
        }
    

        public IList<ModeloNoticia> GetAll()
        {
            IList<ModeloNoticia> listaNoticia = new List<ModeloNoticia>();
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
                            listaNoticia.Add(new ModeloNoticia()
                            {
                                IdNoticia = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                SubTitulo = reader.GetString(2),
                                Autor = reader.GetString(3),
                                FechaPublicacion = reader.GetString(4),
                                Noticia = reader.GetString(5)
                            });
                        }
                    }
                }
                server.Close();
            }
            return listaNoticia;
        }
    

        public void  Update(ModeloNoticia obj)
        {
            ModeloNoticia MNoticia = new ModeloNoticia();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("update from dbo.noticia set="+obj.Noticia+"where IdNoticia="+obj.IdNoticia);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MNoticia = new ModeloNoticia()
                            {
                                IdNoticia = reader.GetInt32(0),
                                Titulo = reader.GetString(1),
                                SubTitulo = reader.GetString(2),
                                Autor = reader.GetString(3),
                                FechaPublicacion = reader.GetString(4),
                                Noticia = reader.GetString(5)
                            };
                        }
                    }
                }
                server.Close();
            }
        }
    }
    
}
