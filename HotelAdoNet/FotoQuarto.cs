using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelAdoNet
{
    public class FotoQuarto
    {
        public int id { get; set; }
        public byte[] Imagem { get; set; }
        public int QuartoId { get; set; }
        public Quarto Quarto { get; set; }
    }
}
