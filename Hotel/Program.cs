using System;

namespace Hotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Pograma - Hotel");
            Console.WriteLine("_______________");

            // -- POR FAZER -- //
            /* UNIT TEST 
            LER COMO FAZER */

            Quarto.PedirQuarto();
            Quarto.PedirQuarto();
            Quarto.MostrarQuartos();

            //Rececao rececaoMain = new Rececao(){ Telefone = 123, Email = "joao.semedo@blabla.com"};
            Rececao rececaoMain = new Rececao();
            rececaoMain.PedirRececao();

            Hotel.CriarHotel(Quarto.QuartoList, rececaoMain);

            // Keep the console window open in debug mode.
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
