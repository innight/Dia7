using System.Collections.Generic;
using System.Diagnostics;

namespace HotelAdoNet
{
    public class Quarto
    {
        public int Id { private set; get;  }
        public int Piso { get; set; }
        public int Numero { get; set; }
        public int Area { get; set; }
        public bool AC { get; set; }
        public string Descricao { get; set; }


        public ICollection<Tipologia> Tipologias { get; set; }
        public ICollection<FotoQuarto> FotoQuartos { get; set; }
        public ICollection<Reserva> Reservas { get; set; }
    }
}

