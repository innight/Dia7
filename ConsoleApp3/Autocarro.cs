using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Autocarro : Veiculo
    {
        private int capacidade;
        public int Capacidade
        {
            get
            {
                return capacidade;
            }
            set
            {
                capacidade = value;
            }
        }

        public override void Pedir()
        {
            base.Pedir();
            Console.Write("Capacidade: ");
            Capacidade = Int32.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Cor: {Cor}\nMarca: {Marca}\nModelo: {Modelo}\nMatricula: {Matricula}\nCapacidade: {Capacidade}";
        }

        public override void Mostrar()
        {
            Console.WriteLine(ToString());
        }
    }
}
