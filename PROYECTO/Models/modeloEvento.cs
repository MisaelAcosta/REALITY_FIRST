namespace PROYECTO.Models
{
    public class ModeloEvento
    {
        private int idEvento;
        private string evento;
        private string lugar;
        private string fechaEvento;
        private string tipoEvento;

        public int IdEvento { get => idEvento; set => idEvento = value; }
        public string Evento { get => evento; set => evento = value; }
        public string Lugar { get => lugar; set => lugar = value; }
        public string FechaEvento { get => fechaEvento; set => fechaEvento = value; }
        public string TipoEvento { get => tipoEvento; set => tipoEvento = value; }

        public ModeloEvento()
        {

        }
    }
}
