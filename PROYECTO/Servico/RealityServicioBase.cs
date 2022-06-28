using PROYECTO.Models;

namespace PROYECTO.Servico
{
    public class RealityServicioBase
    {
        public RealityFirst Get(int id)
        {
            server.Open();

            string query = string.Format("Select * from Arista;");
            using (SqlCommand cmd = new SqlCommand(query, server))
            {
                using (SqlDataReader reader = cmd.ExecuteReader())
                    while (reader.Read())
                    {
                        RealityFirst obj = new RealityFirst()
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

        }

        public RealityFirst Get(int id)
        {
            throw new NotImplementedException();
        }
    }
}