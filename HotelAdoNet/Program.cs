using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace HotelAdoNet
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Hotel _ Relações!");

            using (MeuContexto ctx = new MeuContexto())
            {
                if (ctx.Quartos.Count() == 0)
                {
                    Quarto quarto = new Quarto() { Numero = 1, Area = 2, AC = true };

                    Quarto quarto1 = new Quarto() { Numero = 2, Area = 1, Descricao = "dasd" };

                    ctx.AddRange(quarto, quarto1);
                    ctx.SaveChanges();
                }

                Console.WriteLine($"Numero quartos - {ctx.Quartos.Count()}");
                // Adcionar reservas ao quarto
                Reserva reserva = new Reserva() { DataInicio = DateTime.Now, DataFim = DateTime.Now.AddDays(1), QuartoId = 2 };
                Reserva reserva1 = new Reserva() { DataInicio = DateTime.Now, DataFim = DateTime.Now.AddDays(1), QuartoId = null };

                ctx.AddRange(reserva, reserva1);
                var contador = ctx.SaveChanges();
                Console.WriteLine($"Numero registos alterados - {contador} ");

            }


            // EXERCICIO 14/11/2022

            //EXERCÍCIO: Criar a relação entre as tabelas de Quartos, Tipologias e Reservas - ConsoleApp1
            //      1 Quarto tem 1 Tipologia
            //      1 Tipologia tem Muitos Quartos

            //      1 Reserva é reserva para 1 Tipologia de Quarto
            //      1 Tipologia de Quarto poderá ter Muitas Reservas

        }
    }
}

