using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<AparelhoSom> aparelhos = new List<AparelhoSom>();

        Radio r = new Radio();
        HomeTheater h = new HomeTheater();

        aparelhos.Add(r);
        aparelhos.Add(h);

        for (int i = 0; i < 3; i++)
        {
            foreach (AparelhoSom a in aparelhos)
            {
                a.AumentarVolume();
                Console.WriteLine("Volume atual: " + a.Volume);
            }
        }
    }
}