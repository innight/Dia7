using System;
using System.Collections.Generic;
using System.Text;

namespace Hotel
{
    internal class Hotel
    {
        //utilização de agregação
        public List<Quarto> Quartos { get; set; }
        public Rececao Rececao { get; set; }

        #region STATIC

        public static void CriarHotel(List<Quarto> quartos, Rececao rececao)
        {
            Hotel hotel = new Hotel(quartos, rececao);
        }

        #endregion

        #region NOT-STATIC
        Hotel(List<Quarto> quartos)
        {
            Console.WriteLine("Construtor Inicializado q");
            this.Quartos = quartos;
            Console.WriteLine("Construtor Finalizado q");
        }

        Hotel(List<Quarto> quartos, Rececao rececao)
        {
            Console.WriteLine("Construtor Inicializado qr");
            this.Quartos = quartos;
            this.Rececao = rececao;
            Console.WriteLine("Construtor Finalizado qr");
        }
        #endregion

    }
}
