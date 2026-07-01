using System;
using System.Collections.Generic;

abstract class Produto
{
    public double Preco;
    public abstract double CalcularPreco();
}

class ProdutoNacional : Produto
{
    public override double CalcularPreco()
    {
        return Preco;
    }
}

class ProdutoImportado : Produto
{
    public override double CalcularPreco()
    {
        return Preco * 1.2 + 10;
    }
}

class Carrinho
{
    public List<Produto> produtos = new List<Produto>();

    public double Total()
    {
        double soma = 0;
        foreach (var p in produtos)
            soma += p.CalcularPreco();
        return soma;
    }
}

class Program
{
    static void Main()
    {
        Carrinho c = new Carrinho();
        c.produtos.Add(new ProdutoNacional { Preco = 100 });
        c.produtos.Add(new ProdutoImportado { Preco = 100 });

        Console.WriteLine(c.Total());
    }
}