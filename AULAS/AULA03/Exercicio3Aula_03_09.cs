using System;

namespace Aula0903
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome, posicao;
            int itens, direcao;
            double dano;

            Console.WriteLine("Nome:");
            nome = Console.ReadLine();

            Console.WriteLine("Posicao:");
            posicao = Console.ReadLine();

            Console.WriteLine("Itens:");
            itens = int.Parse(Console.ReadLine());

            Personagem p1 = new Personagem(nome, posicao, itens);

            Console.WriteLine("Dano:");
            dano = double.Parse(Console.ReadLine());
            p1.Atacar(dano);

            Console.WriteLine("Direcao:");
            direcao = int.Parse(Console.ReadLine());
            p1.Movimentar(direcao);
        }
    }

    class Personagem
    {
        public string nome, posicao;
        public int itens;

        public Personagem(string nome, string posicao, int itens)
        {
            this.nome = nome;
            this.posicao = posicao;
            this.itens = itens;
        }

        public void Atacar(double dano)
        {
            Console.WriteLine("Dano: " + dano);
        }

        public void Movimentar(int d)
        {
            if (d == 1) Console.WriteLine("Frente");
            else if (d == 2) Console.WriteLine("Tras");
            else if (d == 3) Console.WriteLine("Direita");
            else if (d == 4) Console.WriteLine("Esquerda");
        }
    }
}