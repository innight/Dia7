using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;

namespace HotelAdoNet
{
    public class Quarto
    {
        [Key]
        public int Id { private set; get;  }
        public int Piso { get; set; }
        public int Numero { get; set; }
        public int Area { get; set; }
        public bool AC { get; set; }
        public string Descricao { get; set; }

        // Navigation Property 1:N
        public ICollection<FotoQuarto> FotoQuartos { get; set; }

        public int TipologiaId { get; set; }
        public Tipologia Tipologia { get; set; }
    }
}

