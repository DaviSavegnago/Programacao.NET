using System;
using System.Collections.Generic;

abstract class Mensagem
{
    public string Texto;
    public abstract void Enviar();
}

class Email : Mensagem
{
    public override void Enviar()
    {
        Console.WriteLine("Enviando EMAIL: " + Texto);
    }
}

class SMS : Mensagem
{
    public override void Enviar()
    {
        Console.WriteLine("Enviando SMS: " + Texto);
    }
}

class Program
{
    static void Main()
    {
        List<Mensagem> mensagens = new List<Mensagem>();

        mensagens.Add(new Email { Texto = "Olá por email" });
        mensagens.Add(new SMS { Texto = "Olá por SMS" });

        foreach (var m in mensagens)
            m.Enviar();
    }
}