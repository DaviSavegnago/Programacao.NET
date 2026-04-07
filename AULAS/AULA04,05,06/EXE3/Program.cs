using System;

class Program
{
    static void Main(string[] args)
    {
        // Criando objetos
        Quadrado q = new Quadrado();
        Retangulo r = new Retangulo();

        // Entrada de dados (Console.ReadLine)
        Console.Write("Digite o lado do quadrado: ");
        q.Lado = double.Parse(Console.ReadLine());

        Console.Write("Digite a base do retângulo: ");
        r.Base = double.Parse(Console.ReadLine());

        Console.Write("Digite a altura do retângulo: ");
        r.Altura = double.Parse(Console.ReadLine());

        // Exibindo resultados
        Console.WriteLine("Área do quadrado: " + q.CalcularArea());
        Console.WriteLine("Área do retângulo: " + r.CalcularArea());
    }
}