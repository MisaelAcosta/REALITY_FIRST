namespace PROYECTO.Models
{
    public class ModeloTicket
    {
        private int idticket;
        private string tipo;
        private string espacio;
        private int precio;

        public int Idticket { get => idticket; set => idticket = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public string Espacio { get => espacio; set => espacio = value; }
        public int Precio { get => precio; set => precio = value; }

        public ModeloTicket()
        {

        }
    }
}
