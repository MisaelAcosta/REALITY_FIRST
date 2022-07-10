using Microsoft.Data.SqlClient;
using PROYECTO.Models;
using PROYECTO.Servico.Contrato;

namespace PROYECTO.Servico
{
    public class TicketServicio : IServicio<ModeloTicket>
    {
        private string Connection;

        public TicketServicio(String ConneccionString)
        {
            this.Connection=  ConneccionString;
        }

        public void Create(ModeloTicket obj)
        {
            ModeloTicket MTicket = new ModeloTicket();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("insert into dbo.ticket values("+obj.Idticket+",'"+obj.Tipo+"','"+obj.Espacio+"',"+obj.Precio+");");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MTicket = new ModeloTicket()
                            {
                                Idticket=reader.GetInt32(0),
                                Tipo=reader.GetString(1),
                                Espacio=reader.GetString(2),
                                Precio=reader.GetInt32(3)
                            };
                        }
                    }
                }
                server.Close();
            }
        }

        public void Delete(int id)
        {
            ModeloTicket MTicket = new ModeloTicket();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("delete from dbo.ticket where IdTicket="+id);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MTicket = new ModeloTicket()
                            {
                                Idticket = reader.GetInt32(0),
                                Tipo = reader.GetString(1),
                                Espacio = reader.GetString(2),
                                Precio = reader.GetInt32(3)
                            };
                        }
                    }
                }
                server.Close();
            }
        }

        public ModeloTicket Get(int id)
        {
            ModeloTicket MTicket = new ModeloTicket();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("select * from dbo.ticket where IdTicket=" + id);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MTicket = new ModeloTicket()
                            {
                                Idticket = reader.GetInt32(0),
                                Tipo = reader.GetString(1),
                                Espacio = reader.GetString(2),
                                Precio = reader.GetInt32(3)
                            };
                        }
                    }
                }
                server.Close();
            }
            return MTicket;
        }

        public IList<ModeloTicket> GetAll()
        {
            IList<ModeloTicket> ListaEntradas = new List<ModeloTicket>();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("select * from dbo.ticket;");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ListaEntradas.Add(new ModeloTicket()
                            {
                                Idticket = reader.GetInt32(0),
                                Tipo = reader.GetString(1),
                                Espacio = reader.GetString(2),
                                Precio = reader.GetInt32(3)
                            });
                        }
                    }
                }
                server.Close();
            }
            return ListaEntradas;
        }

        public void Update(ModeloTicket obj)
        {
            ModeloTicket MTicket = new ModeloTicket();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("update dbo.ticket set precio = "+obj.Precio+" where IdTicket="+obj.Idticket);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MTicket = new ModeloTicket()
                            {
                                Idticket = reader.GetInt32(0),
                                Tipo = reader.GetString(1),
                                Espacio = reader.GetString(2),
                                Precio = reader.GetInt32(3)
                            };
                        }
                    }
                }
                server.Close();
            }
        }
    }
}
