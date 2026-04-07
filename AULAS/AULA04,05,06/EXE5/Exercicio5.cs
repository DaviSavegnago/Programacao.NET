using System;

abstract class Conta
{
    protected double saldo;

    public Conta(double saldoInicial)
    {
        saldo = saldoInicial;
    }

    public abstract void Sacar(double valor);

    public double GetSaldo()
    {
        return saldo;
    }
}

class ContaCorrente : Conta
{
    public ContaCorrente(double saldoInicial) : base(saldoInicial) { }

    public override void Sacar(double valor)
    {
        if (saldo >= valor)
            saldo -= valor;
    }
}

class ContaPoupanca : Conta
{
    public ContaPoupanca(double saldoInicial) : base(saldoInicial) { }

    public override void Sacar(double valor)
    {
        double total = valor + 0.5;
        if (saldo >= total)
            saldo -= total;
    }
}

class Program
{
    static void Main()
    {
        Conta c1 = new ContaCorrente(100);
        Conta c2 = new ContaPoupanca(100);

        c1.Sacar(50);
        c2.Sacar(50);

        Console.WriteLine(c1.GetSaldo());
        Console.WriteLine(c2.GetSaldo());
    }
}