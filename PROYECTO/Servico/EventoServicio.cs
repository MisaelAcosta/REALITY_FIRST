using Microsoft.Data.SqlClient;
using PROYECTO.Models;
using PROYECTO.Servico.Contrato;

namespace PROYECTO.Servico
{
    public class EventoServicio : IServicio<ModeloEvento>
    {
        private string Connection;

        public EventoServicio(String ConneccionString)
        {
            this.Connection = ConneccionString;
        }

        public void Create(ModeloEvento obj)
        {
            ModeloEvento MEvento = new ModeloEvento();
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
                            MEvento = new ModeloEvento()
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
            ModeloEvento MEvento = new ModeloEvento();
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
                            MEvento = new ModeloEvento()
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

        public ModeloEvento Get(int id)
        {
            ModeloEvento MEvento = new ModeloEvento();
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
                            MEvento = new ModeloEvento()
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

        public IList<ModeloEvento> GetAll()
        {
            IList<ModeloEvento> listaEvento = new List<ModeloEvento>();
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
                            listaEvento.Add(new ModeloEvento()
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

        public void Update(ModeloEvento obj)
        {
            ModeloEvento MEvento = new ModeloEvento();
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
                            MEvento = new ModeloEvento()
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
