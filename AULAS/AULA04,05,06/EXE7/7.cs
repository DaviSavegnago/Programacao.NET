using System;
using System.Collections.Generic;

abstract class ItemBiblioteca
{
    public string Titulo;
    public string Autor;
    public abstract void ExibirDestaque();
}

class Livro : ItemBiblioteca
{
    public override void ExibirDestaque()
    {
        Console.WriteLine(Titulo.ToUpper());
    }
}

class Revista : ItemBiblioteca
{
    public int Edicao;

    public override void ExibirDestaque()
    {
        Console.WriteLine(Titulo + " - Edição " + Edicao);
    }
}

class Program
{
    static void Main()
    {
        List<ItemBiblioteca> itens = new List<ItemBiblioteca>();

        itens.Add(new Livro { Titulo = "Livro exemplo", Autor = "Autor" });
        itens.Add(new Revista { Titulo = "Revista exemplo", Autor = "Autor", Edicao = 5 });

        foreach (var i in itens)
            i.ExibirDestaque();
    }
}