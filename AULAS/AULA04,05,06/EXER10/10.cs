using System;
using System.Collections.Generic;

abstract class Funcionario
{
    public double SalarioBase;
    public abstract double CalcularPagamento();
}

class Vendedor : Funcionario
{
    public double Vendas;

    public override double CalcularPagamento()
    {
        return SalarioBase + (Vendas * 0.10);
    }
}

class Gerente : Funcionario
{
    public double Bonus;

    public override double CalcularPagamento()
    {
        return SalarioBase + Bonus;
    }
}

class Program
{
    static void Main()
    {
        List<Funcionario> lista = new List<Funcionario>();

        lista.Add(new Vendedor { SalarioBase = 2000, Vendas = 40000 });
        lista.Add(new Gerente { SalarioBase = 3000, Bonus = 2500 });

        foreach (var f in lista)
        {
            double total = f.CalcularPagamento();
            Console.WriteLine(total);

            if (total > 5000)
                Console.WriteLine("Alerta de Orçamento");
        }
    }
}