using System;
using System.Collections.Generic;
using System.Drawing;

namespace ConsoleApp3
{
    internal abstract class Veiculo /* :  IVeiculo */
    {
        public static List<Veiculo> VeiculoList = new List<Veiculo>();
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Cilindrada { get; set; }
        public string Matricula { get; set; }

        // ESTUDAR MELHOR ESTE CASO????
        //public virtual void ApagarVeiculo(List<Veiculo> VeiculoListInput, Guid id)
        //{
        //    Console.WriteLine("Entrei na classe base...");

        //}

        #region Nonstaticmembers

        /// <summary>
        /// Inicia construtor Veiculio com ID preenchido; Cor preenchida
        /// </summary>
        public Veiculo()
        {
            Cor = "asdasd";
        }
        /// <summary>
        /// Inserir Veiculo
        /// </summary>
        /// 
        public virtual void Pedir()
        {

            Console.Clear();
            Console.Write("\tINFORMACAO PARA PREENCHER:\t\n");

            Console.Write("Cilindrada: ");
            try
            {
                Cilindrada = Int32.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("erro por favor tente novamente");
                //throw;
            }


            Console.Write("Cor: ");
            Cor = Console.ReadLine();

            Console.Write("Marca: ");
            Marca = Console.ReadLine();

            Console.Write("Modelo: ");
            Modelo = Console.ReadLine();

            Console.Write("Matricula: ");
            Matricula = Console.ReadLine();
        }

        //A classe Pessoa herda da classe Object implicitamente (não foi necessário indicar : Object).
        //Posso por isso efetuar o override dos métodos herdados:
        public override string ToString()
        {
            return $"ID: {Id}\tCor: {Cor}\tMarca: {Marca}\tModelo: {Modelo}\tMatricula: {Matricula}\n";
        }

        /// <summary>
        /// Mostar Veiculo
        /// </summary>
        public void Mostrar()
        {
            //Para não repetir código, vou chamar o método ToString:
            Console.WriteLine(ToString());
        }

        /// <summary>
        /// Alterar veiculo
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Alterar(Guid idInput)
        {
            Console.WriteLine("classe base");  
        }

        /// <summary>
        /// Apagar veiculo
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        public void Apagar()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region StaticMembers

        public static void  MostrarTodosVeiculos()
        {
            foreach (Veiculo veiculo in VeiculoList)
            {
                veiculo.Mostrar();
            }
        }
        #endregion

    }
}