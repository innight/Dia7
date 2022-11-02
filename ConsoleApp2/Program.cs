using System;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Pessoa pessoa1 = new Pessoa();
            Pessoa pessoa2 = new Pessoa(1, "nome de pessoa");

            Formando f1 = new Formando();
            Formando f2 = new Formando(2, "nome de formando", "curso do formando");
            Console.WriteLine(f2.Nome);
        }
    }
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        //Todas as classes podem ter métodos construtores:
        public Pessoa()
        {
            Id = 0;
            Nome = "";
        }
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
    }
    class Formando : Pessoa
    {
        public string Curso { get; set; }
        //Todas as classes podem ter métodos construtores:
        //Posso definir assim os métodos construtores desta classe Formando:
        //public Formando()
        //{
        //    Id = 0;
        //    Nome = "";
        //    Curso = "";
        //}
        //public Formando(int id, string nome, string curso)
        //{
        //    Id = id;
        //    Nome = nome;
        //    Curso = curso;
        //}
        //OU, COMO ESTA CLASSE DERIVA DE PESSOA E PESSOA JÁ TEM MÉTODOS CONSTRUTORES:
        public Formando() : base()
        {
            //NOTA: a sitaxe ": base()" indica que este construtor vai chamar o respetivo construtor da classe base Pessoa!
            //Assim, não preciso inicializar as props Id e Nome:
            //Id = 0;
            //Nome = "";
            Curso = "";
        }
        public Formando(int id, string nome, string curso) : base(id, nome)
        {
            //NOTA: a sitaxe ": base(id, nome)" indica que este construtor vai chamar o respetivo construtor da classe base Pessoa - com os argumentos indicados!
            //Assim, não preciso inicializar as props Id e Nome:
            //Id = id;
            //Nome = nome;
            Curso = curso;
        }
    }
}
