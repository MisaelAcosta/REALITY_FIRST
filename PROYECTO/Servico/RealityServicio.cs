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

                string query = string.Format("Select * from Artista;");
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

        public RealityFirst GetEvento(int id)
        {
            RealityFirst RFirstEvento = new RealityFirst();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();

                string query = string.Format("Select * from Evento;");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            RFirstEvento = new RealityFirst()
                            {
                                IdEvento = reader.GetInt32(0),
                                Evento = reader.GetString(1),
                                lugar=reader.GetString(2),
                                fechaEvento = reader.GetString(3),
                                IdArtista = reader.GetInt32(4),
                                tipoEvento = reader.GetString(5)
                            };
                        }
                }
                server.Close();
            }
            return RFirstEvento;


        }
        public IList<RealityFirst> GetAllEvento()
        {
            IList<RealityFirst> listaEvento = new List<RealityFirst>();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("select * from evento;");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listaEvento.Add(new RealityFirst()
                        {
                            IdEvento = reader.GetInt32(0),
                            Evento = reader.GetString(1),
                            lugar = reader.GetString(2),
                            fechaEvento = reader.GetString(3),
                            IdArtista=reader.GetInt32(4),
                            tipoEvento = reader.GetString(5)
                        });
                    }
                }
                server.Close();

            }

            return listaEvento;
        }

        public RealityFirst GetNoticia(int id)
        {
            RealityFirst RFirstNoticia = new RealityFirst();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();

                string query = string.Format("Select * from Evento;");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            RFirstNoticia = new RealityFirst()
                            {
                                IdNoticia = reader.GetInt32(0),
                                titulo= reader.GetString(1),
                                subTitulo= reader.GetString(2),
                                autor= reader.GetString(3),
                                fechaPublicacion= reader.GetString(4),
                                noticia=reader.GetString(5),
                                IdArtista=reader.GetInt32(6)
                            };
                        }
                }
                server.Close();
            }
            return RFirstNoticia;


        }
        public IList<RealityFirst> GetAllNoticia()
        {
            IList<RealityFirst> listaNoticia = new List<RealityFirst>();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("select * from evento;");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listaNoticia.Add(new RealityFirst()
                        {
                            IdNoticia = reader.GetInt32(0),
                            titulo = reader.GetString(1),
                            subTitulo = reader.GetString(2),
                            autor = reader.GetString(3),
                            fechaPublicacion = reader.GetString(4),
                            noticia = reader.GetString(5),
                            IdArtista = reader.GetInt32(6)
                        });
                    }
                }
                server.Close();

            }

            return listaNoticia;
        }
        public RealityFirst GetTicket(int id)
        {
            RealityFirst RFirstTicket = new RealityFirst();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();

                string query = string.Format("Select * from Ticket;");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                        while (reader.Read())
                        {
                            RFirstTicket = new RealityFirst()
                            {
                                Idticket = reader.GetInt32(0),
                                tipo= reader.GetString(1),
                                espacio = reader.GetString(2),
                                precio=reader.GetInt32(3),
                                IdArtista= reader.GetInt32(4)
                            };
                        }
                }
                server.Close();
            }
            return RFirstTicket;


        }
        public IList<RealityFirst> GetAllTicket()
        {
            IList<RealityFirst> listaTicket = new List<RealityFirst>();
            using (SqlConnection server = new SqlConnection(Connection))
            {
                server.Open();
                string query = string.Format("select * from evento;");
                using (SqlCommand cmd = new SqlCommand(query, server))
                {
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        listaTicket.Add(new RealityFirst()
                        {
                            Idticket = reader.GetInt32(0),
                            tipo = reader.GetString(1),
                            espacio = reader.GetString(2),
                            precio = reader.GetInt32(3),
                            IdArtista = reader.GetInt32(4)
                        });
                    }
                }
                server.Close();

            }

            return listaTicket;
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
