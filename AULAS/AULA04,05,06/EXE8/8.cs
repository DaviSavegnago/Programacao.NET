using System;
using System.Collections.Generic;

class Personagem
{
    public virtual void Atacar()
    {
        Console.WriteLine("Ataque genérico");
    }
}

class Guerreiro : Personagem
{
    public override void Atacar()
    {
        Console.WriteLine("Espada");
    }
}

class Mago : Personagem
{
    public override void Atacar()
    {
        Console.WriteLine("Magia");
    }
}

class Program
{
    static void Main()
    {
        List<Personagem> personagens = new List<Personagem>();
        personagens.Add(new Guerreiro());
        personagens.Add(new Mago());

        for (int i = 0; i < 3; i++)
        {
            foreach (var p in personagens)
                p.Atacar();
        }
    }
}
