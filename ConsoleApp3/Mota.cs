using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Mota : Veiculo
    {
        public int numEscapes { get; set; }

        public override void Pedir()
        {
            base.Pedir();
            Console.Write("NumEscapes: ");
            numEscapes = Int32.Parse(Console.ReadLine());
        }

        public override string ToString()
        {
            return $"Cor: {Cor}\nMarca: {Marca}\nModelo: {Modelo}\nMatricula: {Matricula}\nNumEcapes: {numEscapes}";
        }

        public override void Mostrar()
        {
            Console.WriteLine(ToString());
        }
    }
}
