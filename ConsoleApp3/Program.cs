using System;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercício");

            //Criar as classes (base e derivadas), os métodos (virtuais e overrides) e os construtores (sem e com argumentos) de uma solução de gestão de uma escola de condução / rent-a-car.
            //http://escolaconducaoestremocense.pt/499-2/

            //Pelo menos as classes:
            //Veículo - matricula, ...
            //Veículo 2 rodas - pneu1, pneu2, ...
            //Veículo 4 rodas - pneu1, pneu2, 3, 4, ...
            //4 rodas ligeiro
            //4 rodas ligeiro com reboque - ..., peso maximo do reboque
            //4 rodas pesado
            //4 rodas pesado de mercadorias
            //4 rodas pesado de passageiros - numero de passageiros

            //EXTRA
            // Menu que permita adicionar veiculos e listar (de cada uma das categorias)

            /// MENU GERAL

            //1 - registar veiculo
            //2 - listar veiculo
            //0 - Sair

            //Menu de registo de veiculo
            //1 - registar motociclo(2 rodas)
            //2 - registar veiculo ligeiro
            //3 - registar veiculo pesado de mercadorias;


            //VER VIDEO
            // https://www.youtube.com/watch?v=8FmE_-QXg3Y- https://www.youtube.com/watch?v=8FmE_-QXg3Y
            // C# overloaded constructors- https://www.youtube.com/watch?v=OLxIscUoTgY
            // constructor https://www.youtube.com/watch?v=Reeefq-Nxkk


            //Mota m = new Mota();
            //m.Pedir();
            //m.Mostrar();

            //Autocarro auto = new Autocarro();
            //auto.Pedir();
            //auto.Mostrar();

            Carro c = new Carro();
            c.Pedir();
            c.Mostrar();


            Console.ReadKey();

        }
    }
}
