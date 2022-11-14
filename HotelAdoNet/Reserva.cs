using System;
using System.Collections.Generic;

namespace HotelAdoNet
{
    public class Reserva
    {
        public int Id { private set; get; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }
        public int? QuartoId { get; set; }
        public Quarto Quarto { get; set; }

    }
}
