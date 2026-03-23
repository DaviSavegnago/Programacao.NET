using System;

namespace Aula0903
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string titulo, autor;
            int ano;

            Console.WriteLine("Titulo:");
            titulo = Console.ReadLine();

            Console.WriteLine("Autor:");
            autor = Console.ReadLine();

            Console.WriteLine("Ano:");
            ano = int.Parse(Console.ReadLine());

            Livro l1 = new Livro(titulo, autor, ano);

            Console.WriteLine("Titulo:");
            titulo = Console.ReadLine();

            Console.WriteLine("Autor:");
            autor = Console.ReadLine();

            Console.WriteLine("Ano:");
            ano = int.Parse(Console.ReadLine());

            Livro l2 = new Livro(titulo, autor, ano);

            l1.Emprestar();
            l1.Devolver();
        }
    }

    class Livro
    {
        public string titulo, autor;
        public int ano;
        public bool emprestado;

        public Livro(string titulo, string autor, int ano)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.ano = ano;
            emprestado = false;
        }

        public void Emprestar()
        {
            emprestado = true;
            Console.WriteLine("Emprestado");
        }

        public void Devolver()
        {
            emprestado = false;
            Console.WriteLine("Devolvido");
        }
    }
}