namespace Aula0203pratica1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CALCULADORA PARA LER UMA OPERAÇÃO");

            double numero1, numero2, resultado;
            int operacao;

            Console.WriteLine("Digite o primeiro número: ");
            numero1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Digite o segundo número: ");
            numero2 = double.Parse(Console.ReadLine());

            Console.WriteLine("MENU - ESCOLHA A OPERAÇÃO");
            Console.WriteLine("DIGITE 1 para Soma");
            Console.WriteLine("DIGITE 2 para Subtração");
            Console.WriteLine("DIGITE 3 para Divisão");
            Console.WriteLine("DIGITE 4 para Multiplicação");

            operacao = int.Parse(Console.ReadLine());

            switch (operacao)
            {
                case 1:                                                     //if (operacao == 1) {
                    resultado = numero1 + numero2;                          // 
                    Console.WriteLine("Resultado Soma: " + resultado);
                    break;

                case 2:                                                     // else if (operacao == 2) {
                    resultado = numero1 - numero2;
                    Console.WriteLine("Resultado Subtração: " + resultado);
                    break;

                case 3:                                                     // else if (operacao == 3) {
                   resultado = numero1 / numero2;
                   Console.WriteLine("Resultado Divisão: " + resultado);
                    break;
                  
                case 4:                                                    // else if (operacao == 4) {
                    resultado = numero1 * numero2;
                    Console.WriteLine("Resultado Multiplicação: " + resultado);
                    break;

                default:                                                    // else {
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }
}
