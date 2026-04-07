using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Lista de animais
        List<Animal> animais = new List<Animal>();

        // Criando objetos
        Cachorro c = new Cachorro();
        c.Nome = "Rex";

        Gato g = new Gato();
        g.Nome = "Mimi";

        // Adicionando na lista
        animais.Add(c);
        animais.Add(g);

        foreach (Animal a in animais)
        {
            a.EmitirSom();
        }
    }
}