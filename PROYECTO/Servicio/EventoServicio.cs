using Microsoft.Data.SqlClient;
using PROYECTO.Models;
using PROYECTO.Servicio;

namespace PROYECTO.Servico
{
    public class EventoServicio : IServicio<Evento>
    {
        private string Connection;

        public EventoServicio(String ConneccionString)
        {
            this.Connection = ConneccionString;
        }

        public void Create(Evento obj)
        {
            Evento MEvento = new Evento();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("insert into dbo.evento values("+obj.IdEvento+",'"+obj.Nombre+"','"+obj.FechaEvento
                    +"','"+obj.Lugar+"','"+obj.TipoEvento+"´);");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MEvento = new Evento()
                            {
                                IdEvento = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                FechaEvento = reader.GetString(2),
                                Lugar=reader.GetString(3),
                                TipoEvento=reader.GetString(4)
                            };
                        }
                    }
                }
                server.Close();
            }
        }

        public void Delete(int id)
        {
            Evento MEvento = new Evento();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("delete from dbo.evento where IdEvento = "+id);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MEvento = new Evento()
                            {
                                IdEvento = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                FechaEvento = reader.GetString(2),
                                Lugar = reader.GetString(3),
                                TipoEvento = reader.GetString(4)
                            };
                        }
                    }
                }
                server.Close();
            }
        }

        public Evento Get(int id)
        {
            Evento MEvento = new Evento();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("select * from dbo.evento where IdEvento = "+id);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MEvento = new Evento()
                            {
                                IdEvento = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                FechaEvento = reader.GetString(2),
                                Lugar = reader.GetString(3),
                                TipoEvento = reader.GetString(4)
                            };
                        }
                    }
                }
                server.Close();
            }
            return MEvento;
        }

        public IList<Evento> GetAll()
        {
            IList<Evento> listaEvento = new List<Evento>();
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
                            listaEvento.Add(new Evento()
                            {
                                IdEvento = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                FechaEvento = reader.GetString(2),
                                Lugar = reader.GetString(3),
                                TipoEvento = reader.GetString(4)
                            });
                        }
                    }
                }
                server.Close();
            }
            return listaEvento;
        }

        public void Update(Evento obj)
        {
            Evento MEvento = new Evento();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("update dbo.evento set Evento="+obj.Nombre + " where IdEvento = "+obj.IdEvento);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MEvento = new Evento()
                            {
                                IdEvento = reader.GetInt32(0),
                                Nombre = reader.GetString(1),
                                FechaEvento = reader.GetString(2),
                                Lugar = reader.GetString(3),
                                TipoEvento = reader.GetString(4)
                            };
                        }
                    }
                }
                server.Close();
            }
        }
    }
}
