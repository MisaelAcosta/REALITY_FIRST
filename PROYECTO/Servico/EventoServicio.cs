using Microsoft.Data.SqlClient;
using PROYECTO.Models;
using PROYECTO.Servico.Contrato;

namespace PROYECTO.Servico
{
    public class EventoServicio : IServicio<modeloEvento>
    {
        private string Connection;

        public EventoServicio(String ConneccionString)
        {
            this.Connection = ConneccionString;
        }

        public void Create(modeloEvento obj)
        {
            modeloEvento MEvento = new modeloEvento();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("insert into dbo.evento values("+obj.IdEvento+",'"+obj.Evento+"','"+obj.FechaEvento
                    +"','"+obj.Lugar+"','"+obj.TipoEvento+"´);");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MEvento = new modeloEvento()
                            {
                                IdEvento = reader.GetInt32(0),
                                Evento = reader.GetString(1),
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
            modeloEvento MEvento = new modeloEvento();
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
                            MEvento = new modeloEvento()
                            {
                                IdEvento = reader.GetInt32(0),
                                Evento = reader.GetString(1),
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

        public modeloEvento Get(int id)
        {
            modeloEvento MEvento = new modeloEvento();
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
                            MEvento = new modeloEvento()
                            {
                                IdEvento = reader.GetInt32(0),
                                Evento = reader.GetString(1),
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

        public IList<modeloEvento> GetAll()
        {
            IList<modeloEvento> listaEvento = new List<modeloEvento>();
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
                            listaEvento.Add(new modeloEvento()
                            {
                                IdEvento = reader.GetInt32(0),
                                Evento = reader.GetString(1),
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

        public void Update(modeloEvento obj)
        {
            modeloEvento MEvento = new modeloEvento();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("update dbo.evento set Evento="+obj.Evento+" where IdEvento = "+obj.IdEvento);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MEvento = new modeloEvento()
                            {
                                IdEvento = reader.GetInt32(0),
                                Evento = reader.GetString(1),
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
