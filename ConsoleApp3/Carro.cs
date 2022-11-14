using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Carro  : Veiculo /*, IVeiculo */
    {
        public bool Descapotavel { get; set; }

        /// <summary>
        /// Iniciliza lista - Carros publica
        /// </summary>
        public static List<Carro> CarroList = new List<Carro>();

        /// <summary>
        /// Construtor
        /// </summary>
        public Carro():base()
        {
            Cor = "CorVazia";
            Marca = "MarcaVazia";
            Modelo = "Vazio";
            Cilindrada = 0000;
            Matricula = "xx-xx-yy";
            Descapotavel = true;
        }

        public override void Pedir()
        {
            base.Pedir();
            
            Console.WriteLine("Descapotavel: ");
            Descapotavel = bool.Parse(Console.ReadLine());
        }

        public static void AlterarCarro(Guid idInput)
        {
            foreach (var carro in Carro.CarroList)
            {
                if (carro.Id == idInput)
                {
                    carro.Pedir();
                    break;
                }
            }
        }

        public static void ApagarCarro(Guid idInput)
        {
            foreach (var carro in Carro.CarroList)
            {
                if (carro.Id == idInput)
                {
                    CarroList.Remove(carro);
                    break;
                }
            }
        }

        /// <summary>
        /// Metodo ToString
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return $"ID: {Id}\nCor: {Cor}\nMarca: {Marca}\nModelo: {Modelo}\nMatricula: {Matricula}\nDescapotavel: {Descapotavel}\n";
        }

        /// <summary>
        /// Mostra todos carros existentes
        /// </summary>
        public static void MostrarTodosCarros()
        {
            foreach (Carro carro in CarroList)
            {
                carro.Mostrar();
                Console.WriteLine("");
            }
        }
    }
}
