using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Carro : Veiculo
    {
        public bool Descapotavel { get; set; }

        public Carro()
        {
            Descapotavel = true;
        }

        public override string ToString()
        {
            return $"Cor: {Cor}\nMarca: {Marca}\nModelo: {Modelo}\nMatricula: {Matricula}\nDescapotavel: {Descapotavel}";
        }

        public override void Mostrar()
        {
            Console.WriteLine(ToString());
        }
    }
}
