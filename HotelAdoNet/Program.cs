//using HotelAdoNet.Migrations;
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
                var e = ctx.Database.EnsureCreated();
                if (e) Console.WriteLine("Database has been created!");

                // Criar instancias da classe Tipologia
                if (ctx.Tipologias.Count() == 0)
                {
                    Tipologia tipologia = new Tipologia() { Nome = "Quarto duplo" };

                    Tipologia tipologia1 = new Tipologia() { Nome = "Suite" };

                    ctx.AddRange(tipologia, tipologia1);
                    ctx.SaveChanges();
                }

                // Criar instancias da classe Quarto
                if (ctx.Quartos.Count() == 0)
                {
                    Quarto quarto = new Quarto() { Numero = 1, Area = 2, AC = true, TipologiaId = 1 };

                    Quarto quarto1 = new Quarto() { Numero = 2, Area = 1, Descricao = "dasd", TipologiaId = 2 };

                    ctx.AddRange(quarto, quarto1);
                    ctx.SaveChanges();
                }

                Console.WriteLine($"Numero quartos - {ctx.Quartos.Count()}");


                // Criar instancias da classe Reserva
                if (ctx.Reservas.Count() == 0)
                {
                    Reserva reserva = new Reserva() { DataInicio = DateTime.Now, DataFim = DateTime.Now.AddDays(1), TipologiaId = 2 };
                    Reserva reserva1 = new Reserva() { DataInicio = DateTime.Now, DataFim = DateTime.Now.AddDays(1), TipologiaId = 1 };

                    // Adicionar Reservas ao ContextDb
                    ctx.AddRange(reserva, reserva1);
                    var contador = ctx.SaveChanges();
                    Console.WriteLine($"Numero registos alterados - {contador} ");

                    foreach (var r in ctx.Reservas.Where(x => x.TipologiaId == 1).ToList())
                    {
                        Console.WriteLine(r.Id + ": " + r.DataInicio + " " + r.DataFim);
                    }
                }

            }

            Console.WriteLine("Fim!");
            Console.ReadLine();


            // EXERCICIO 14/11/2022

            //EXERCÍCIO: Criar a relação entre as tabelas de Quartos, Tipologias e Reservas - ConsoleApp1
            //      1 Quarto tem 1 Tipologia - FEItO
            //      1 Tipologia tem Muitos Quartos

            //      1 Reserva é reserva para 1 Tipologia de Quarto
            //      1 Tipologia de Quarto poderá ter Muitas Reservas

        }
    }
}