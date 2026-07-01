using System;
using System.Collections.Generic;

class Veiculo
{
    public virtual double CalcularPedagio()
    {
        return 0;
    }
}

class Carro : Veiculo
{
    public override double CalcularPedagio()
    {
        return 10;
    }
}

class Caminhao : Veiculo
{
    public int Eixos;

    public override double CalcularPedagio()
    {
        return 10 * Eixos;
    }
}

class Program
{
    static void Main()
    {
        List<Veiculo> veiculos = new List<Veiculo>();
        double total = 0;
        string op;

        do
        {
            Console.Write("1-Carro 2-Caminhão 0-Sair: ");
            op = Console.ReadLine();

            if (op == "1")
                veiculos.Add(new Carro());
            else if (op == "2")
            {
                Caminhao c = new Caminhao();
                Console.Write("Eixos: ");
                c.Eixos = int.Parse(Console.ReadLine());
                veiculos.Add(c);
            }

        } while (op != "0");

        foreach (var v in veiculos)
            total += v.CalcularPedagio();

        Console.WriteLine("Total: " + total);
    }
}