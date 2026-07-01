using System; 

  

namespace ConsoleApp1Aula2302POO 

{ 

    internal class Program 

    { 

        static void Main(string[] args) 

        { 

            Console.Write("Hello, World!\n"); 

            Console.WriteLine("Hello!"); 

            int n1, n2; 

            double d; 

            float f; 

            string nome; 

            String sobrenome; 

            decimal preco; //sugerido utilizar pq faz soma direta do numero 

  

            n1 = 2; 

            n2 = 3; 

            d = 4.33; 

            f = 5.44f; 

            preco = 6.55m; 

  

            nome = "Weverton"; 

            sobrenome = "Genio"; 

            string nomeCompleto = nome + " " + sobrenome; 

            Console.WriteLine("Inteiro: " + n1 + " " + n2); 

            Console.WriteLine("Double: " + d); 

            Console.WriteLine("Float: " + f); 

            Console.WriteLine("Preco: " + preco); 

            Console.WriteLine("Nome Completo: " + nomeCompleto); 

  

            DateTime data = DateTime.Now; 

            Console.WriteLine("Dia: " + data.Day); 

            Console.WriteLine("Dia da semana: " + data.DayOfWeek); 

            Console.WriteLine("Ano: " + data.Year); 

            Console.WriteLine("Mês: " + data.Month); 

            Console.WriteLine("Hora: " + data.Hour); 

            Console.WriteLine("Minuto: " + data.Minute); 

            Console.WriteLine("Completo: " + data); 

  

            string frase1; 

            string frase2; 

            frase1 = "Hoje é segunda-feira."; 

            frase2 = "Dia da melhor aula e do melhor framework"; 

            Console.WriteLine(frase1 + " " + frase2); 

            Console.WriteLine($"{frase1} {frase2}"); 

            Console.WriteLine($"Frase 1 usando interpolação: {frase1}"); 

  

            string disciplina; 

            string curso; 

            Console.WriteLine("Digite o nome do curso: "); 

            curso = Console.ReadLine(); 

            Console.WriteLine("Digite a sua disciplina: "); 

            disciplina = Console.ReadLine(); 

            Console.WriteLine("Curso: "+curso); 

            Console.WriteLine("Disciplina: "+disciplina); 

  

        } 

    } 

} 