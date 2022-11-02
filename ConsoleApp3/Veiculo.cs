using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal abstract class Veiculo
    {

        public string Cor { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public int Cilindrada { get; set; }
        public string Matricula { get; set; }

        public int numPortas;
        public int numPneus;
        virtual public void Pedir()
        {
            Console.Write($"Cor: ");
            Cor = Console.ReadLine();
            Console.Write("Marca: ");
            Marca = Console.ReadLine();
            Console.Write("Modelo: ");
            Modelo = Console.ReadLine();
            Console.Write("Matricula: ");
            Matricula = Console.ReadLine();
            Console.Write("Cilindrada: ");
            Cilindrada = Int32.Parse(Console.ReadLine());
        }
        //A classe Pessoa herda da classe Object implicitamente (não foi necessário indicar : Object).
        //Posso por isso efetuar o override dos métodos herdados:
        public override string ToString()
        {
            return $"Cor: {Cor}\nMarca: {Marca}\nModelo: {Modelo}\nMatricula: {Matricula}";
        }
        virtual public void Mostrar()
        {
            //Para não repetir código, vou chamar o método ToString:
            Console.WriteLine(ToString());
        }
    }
}
