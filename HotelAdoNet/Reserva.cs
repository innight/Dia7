using System;
using System.Collections.Generic;

namespace HotelAdoNet
{
    public class Reserva
    {
        public int Id { private set; get; }
        public DateTime DataInicio { get; set; }
        public DateTime DataFim { get; set; }

        public int TipologiaId { get; set; }
        public Tipologia Tipologia { get; set; }

    }
}
