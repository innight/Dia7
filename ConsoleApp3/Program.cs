using System;
using System.IO;

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
            // https://www.youtube.com/watch?v=8FmE_-QXg3Y- 
            // C# overloaded constructors- https://www.youtube.com/watch?v=OLxIscUoTgY
            // constructor https://www.youtube.com/watch?v=Reeefq-Nxkk
            // C# Car Store Application 01 car class - https://www.youtube.com/watch?v=P0rOJz8epfg&list=PLhPyEFL5u-i03yjAvWPwYyG6s3K0jH8QX&index=3

            // START //

            // Chama Menu
            MainMenu();

            // MENU - veiculo | Pessoa
            // SUBMENU - ADICIONAR/LISTAR Veiculo | Pessoa
            // Valida a idade da pessoa
            // Preenche a categoria do veiculo
            // Adicionar á lista

            Console.ReadKey();
        }

        static void MainMenu()
        {
            char choice;

            do
            {
                Console.WriteLine("Escola Condução:");
                Console.WriteLine("  1. veiculos");
                Console.WriteLine("  2. alunos");
                Console.Write("Escolha a opção (0 para sair): ");
                do
                {
                    choice = (char)Console.Read();
                } while (choice == '\n' | choice == '\r');
            } while (choice > '2' & choice != '0');
            Console.WriteLine("\n");

            switch (choice)
            {
                case '0':
                    Console.WriteLine("Sair");
                    break;
                case '1':
                    //Adicionar Veiculo
                    VehicleMenu();
                    break;
                case '2':
                    Console.WriteLine("2");
                    break;
            }
            Console.WriteLine();
        }

        static void VehicleMenu()
        {
            Console.WriteLine("MENU - VEICULOS:");
            Console.WriteLine("1 - Adicionar Veiculo.");
            Console.WriteLine("2- Listar Veiculos");
            Console.WriteLine("3 - Voltar.");

            byte choice;
            while (true)
            {
                Console.WriteLine("Selecione : ");
                if (byte.TryParse(Console.ReadLine(), out choice))
                {
                    break;
                }
                Console.WriteLine("Pff coloque valor inteiro");
            }

            switch (choice)
            {
                case 1:
                    VehicleAddMenu();
                    break;
                case 2:
                    // Listar Veiculos();
                    break;
                case 3:
                    MainMenu();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
        static void VehicleAddMenu()
        {
            Console.WriteLine("Adiciona - VEICULOS:");
            Console.WriteLine("1 - Carro.");
            Console.WriteLine("2- Mota");
            Console.WriteLine("3- Autocarro");
            Console.WriteLine("4 - Voltar.");

            byte choice;
            while (true)
            {
                Console.WriteLine("Selecione : ");
                if (byte.TryParse(Console.ReadLine(), out choice))
                {
                    break;
                }
                Console.WriteLine("Pff coloque valor inteiro");
            }

            switch (choice)
            {
                case 1:
                    Carro carro = new Carro();
                    carro.Pedir();
                    carro.Mostrar();
                    break;
                case 2:
                    Mota mota = new Mota();
                    mota.Pedir();
                    mota.Mostrar();
                    break;
                case 3:
                    Autocarro auto = new Autocarro();
                    auto.Pedir();
                    auto.Mostrar();
                    break;
                case 4:
                    MainMenu();
                    break;
                default:
                    throw new NotImplementedException();
            }
        }
    }
}
