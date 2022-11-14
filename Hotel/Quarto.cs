using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Text.RegularExpressions;

namespace Hotel
{
    internal class Quarto
    {
        public int Numero { get; set; }
        public int Area { get; set; }
        public bool LuzLigada { get; set; }

        public static List<Quarto> QuartoList = new List<Quarto>();

        public static void PedirQuarto()
        {
            Quarto quarto = new Quarto();

            Console.WriteLine("Numero: ");
            quarto.Numero = int.Parse(Console.ReadLine());
            Console.WriteLine("Area: ");
            quarto.Area = int.Parse(Console.ReadLine());
            if(quarto.Numero % 2 == 0) quarto.LuzLigada = true;  

            QuartoList.Add(quarto);
        }
        public static void MostrarQuartos()
        {
            foreach (Quarto quarto in QuartoList)
            {
                Console.Write(quarto.ToString());
            }
        }
        public override string ToString()
        {
            return $"Numero: {Numero} Area: {Area} LuzLiga: {LuzLigada} \r\n";
        }
    }
}
