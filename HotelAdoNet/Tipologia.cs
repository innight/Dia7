using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HotelAdoNet
{
    public class Tipologia
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Quarto> Quartos { get; set; }
        public ICollection<Reserva> Reservas { get; set; }

    }
}

