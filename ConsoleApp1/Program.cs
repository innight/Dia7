using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("USO DE HERANÇA");
            //Teste1();
            //Teste2();
            //Teste3();


            //Pessoa p = new Pessoa();
            //p.Pedir();
            //p.Mostrar();
            //Será que faz sentido neste projeto ter instâncias da classe pessoa?!??!
            //Se não fizer sentido, posso marcar a classe Pessoa como abstract!
            //      ficou:   abstract class Pessoa { ... }

            Formando f1 = new Formando();


            //VER O DIAGRAMA DE CLASSES NESTE PROJETO:
            // - Para adicionar um diagrama de classes: CLick-direito no projeto > Add new item > Class Diagram.
            // - Se não existir esse item terá de ser instalado no VS: Tools > Get tools and features > individual components > class designer.
        }

        private static void Teste3()
        {
            Formando f1 = new Formando();
            Console.WriteLine(f1);
            //<=>
            Console.WriteLine(f1.ToString());

            f1.Mostrar();
        }

        static void Teste2()
        {
            Formando f1 = new Formando();
            f1.Pedir();
            Formador f2 = new Formador();
            f2.Pedir();

            f1.Mostrar();
            f2.Mostrar();
        }
        private static void Teste1()
        {
            Formador f1 = new Formador() { Id = 1, Nome = "Formador 1", Localidade = "Faro", DataNascimento = new DateTime(2000, 1, 1), Area = "MS" };
            f1.Mostrar();
            Formando f2 = new Formando() { Id = 1, Nome = "Formando 1", Localidade = "Faro", DataNascimento = new DateTime(2000, 1, 1), Curso = "C#" };
            f2.Mostrar();
            Funcionario f3 = new Funcionario() { Id = 1, Nome = "Funcionario 1", Localidade = "Faro", DataNascimento = new DateTime(2000, 1, 1), Departamento = "RH" };
            f3.Mostrar();
            FormandoLiveTraining f4 = new FormandoLiveTraining() { Id = 1, Nome = "Formando 1", Localidade = "Faro", DataNascimento = new DateTime(2000, 1, 1), Curso = "C#", Username = "f4" };
            f4.Mostrar();
        }
    }
    //DECLARAÇÃO DE UMA CLASSE PARA SER BASE DE TOdAS AS OUTRAS - irá ter todos os membros que as classe Formandor, Formando e Funcioário têm em comum:
    abstract class Pessoa //: Object  //TODAS AS CLASSES (QUE NÃO TENHAM HERANÇA DE OUTRA CLASSE) HERDAM DA CLASSE OBJECT!
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Localidade { get; set; }
        public DateTime DataNascimento { get; set; }
        //Este foi o primeiro Mostrar mas depois criei outro mais abaixo.
        //virtual public void Mostrar()
        //{
        //    Console.WriteLine($"Id: {Id}\nNome: {Nome}\nLocalidade: {Localidade}\nDN: {DataNascimento}");
        //}
        virtual public void Pedir()
        {
            Console.Write($"Id: ");
            Id = int.Parse(Console.ReadLine());
            Console.Write("Nome: ");
            Nome = Console.ReadLine();
            Console.Write("Localidade: ");
            Localidade = Console.ReadLine();
            Console.Write("DN: ");
            DataNascimento = DateTime.Parse(Console.ReadLine());
        }
        //A classe Pessoa herda da classe Object implicitamente (não foi necessário indicar : Object).
        //Posso por isso efetuar o override dos métodos herdados:
        public override string ToString()
        {
            return $"Id: {Id}\nNome: {Nome}\nLocalidade: {Localidade}\nDN: {DataNascimento}";
        }
        virtual public void Mostrar()
        {
            //Para não repetir código, vou chamar o método ToString:
            Console.WriteLine(ToString());
        }
    }
    //USO DA CLASSE PESSOA COMO BASE:
    //NOTA: Uma classe só pode ter uma única base!
    internal class Formador : Pessoa
    {
        //Não é necessário declarar aqui os membros que são herdados da classe Pessoa:
        //public int Id { get; set; }
        //public string Nome { get; set; }
        //public string Localidade { get; set; }
        //public DateTime DataNascimento { get; set; }
        public string Area { get; set; }
        //Esta classe herda o método Mostrar da classe Pessoa. No entanto, para poder mostrar tb a prop Area, vou efetuar o override/reescrita do método Mostrar:
        //NOTA: Para poder usar a keyword override deverei marcar o método Mostrar da base como virtual!
        override public void Mostrar()
        {
            //Apesar de estar aqui a reescrever o método Mostrar, não perdi o método Mostrar herdado!
            //Ou seja, não preciso estar aqui a escrever todas as props que já esse método escrevia:
            //Console.WriteLine($"Id: {Id}\nNome: {Nome}\nLocalidade: {Localidade}\nDN: {DataNascimento}");
            //Posso simplesmente chamar o método herdado:
            base.Mostrar(); //A keyword base permite chamar o método da base que tem o mesmo nome que na derivada!
            Console.WriteLine($"Área: {Area}");
        }
        public override void Pedir()
        {
            base.Pedir();
            Console.Write("Área: ");
            Area = Console.ReadLine();
        }
    }
    internal class Formando : Pessoa
    {
        //Não é necessário declarar aqui os membros que são herdados da classe Pessoa:
        //public int Id { get; set; }
        //public string Nome { get; set; }
        //public string Localidade { get; set; }
        //public DateTime DataNascimento { get; set; }
        public string Curso { get; set; }
        //Esta classe herda o método Mostrar da classe Pessoa. No entanto, para poder mostrar tb a prop Area, vou efetuar o override/reescrita do método Mostrar:
        override public void Mostrar()
        {
            //Console.WriteLine($"Id: {Id}\nNome: {Nome}\nLocalidade: {Localidade}\nDN: {DataNascimento}\nCurso: {Curso}");
            base.Mostrar();
            Console.WriteLine($"Curso: {Curso}");
        }
    }
    internal class Funcionario : Pessoa
    {
        //Não é necessário declarar aqui os membros que são herdados da classe Pessoa:
        //public int Id { get; set; }
        //public string Nome { get; set; }
        //public string Localidade { get; set; }
        //public DateTime DataNascimento { get; set; }
        public string Departamento { get; set; }
        override public void Mostrar()
        {
            //Console.WriteLine($"Id: {Id}\nNome: {Nome}\nLocalidade: {Localidade}\nDN: {DataNascimento}");
            base.Mostrar();
            Console.WriteLine($"Departamento: {Departamento}");
        }
    }
    //MAIS UMA CLASSE DERIVADA:
    class FormandoLiveTraining : Formando
    {
        public string Username { get; set; }
        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine($"Username: {Username}");
        }
    }
}
