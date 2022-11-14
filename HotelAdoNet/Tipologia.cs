using System.Collections.Generic;

namespace HotelAdoNet
{
    public class Tipologia
    {
        public int Id { get; set; }
        public int Nome { get; set; }
        public int QuartoId { get; set; }
        public Quarto Quarto { get; set; }
    }
}

