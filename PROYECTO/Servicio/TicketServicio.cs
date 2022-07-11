using Microsoft.Data.SqlClient;
using PROYECTO.Models;
using PROYECTO.Servicio;

namespace PROYECTO.Servicio
{
    public class TicketServicio : IServicio<Ticket>
    {
        private string Connection;

        public TicketServicio(String ConneccionString)
        {
            this.Connection=  ConneccionString;
        }

        public void Create(Ticket obj)
        {
            Ticket MTicket = new Ticket();
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
                            MTicket = new Ticket()
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
            Ticket MTicket = new Ticket();
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
                            MTicket = new Ticket()
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

        public Ticket Get(int id)
        {
            Ticket MTicket = new Ticket();
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
                            MTicket = new Ticket()
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

        public IList<Ticket> GetAll()
        {
            IList<Ticket> ListaEntradas = new List<Ticket>();
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
                            ListaEntradas.Add(new Ticket()
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

        public void Update(Ticket obj)
        {
            Ticket MTicket = new Ticket();
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
                            MTicket = new Ticket()
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

        public Ticket ObtenerTicket(int id)
        {
            Ticket MTicket = new Ticket();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("select precio from dbo.ticket where IdTicket=" + id);
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            MTicket = new Ticket()
                            {
                                Idticket = reader.GetInt32(0),
                                Tipo = reader.GetString(1),
                                Espacio = reader.GetString(2),
                                Precio = reader.GetInt32(3),
                                IdArtista = reader.GetInt32(4)
                                
                            };
                        }
                    }
                }
                server.Close();
            }
            return MTicket;
        }
    }
}
