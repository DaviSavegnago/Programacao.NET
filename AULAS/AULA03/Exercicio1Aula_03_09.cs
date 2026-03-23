using System;

namespace Aula0903
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, curso;
            int idade, matricula;

            Console.WriteLine("Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Idade:");
            idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Curso:");
            curso = Console.ReadLine();

            Console.WriteLine("Matricula:");
            matricula = int.Parse(Console.ReadLine());

            Aluno a1 = new Aluno(nome, idade, curso, matricula);
            a1.Mostrar();
        }
    }

    class Aluno
    {
        public string nome, curso;
        public int idade, matricula;

        public Aluno(string nome, int idade, string curso, int matricula)
        {
            this.nome = nome;
            this.idade = idade;
            this.curso = curso;
            this.matricula = matricula;
        }

        public void Mostrar()
        {
            Console.WriteLine(nome);
            Console.WriteLine(idade);
            Console.WriteLine(curso);
            Console.WriteLine(matricula);
        }
    }
}