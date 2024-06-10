using System; // Utilizar o sistema do .NET / C#

namespace Exercicio_01
{
    internal class Pratica_01 
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Programa de soma!");

            Console.WriteLine("Digite o primeiro número: ");
            string? input01 = Console.ReadLine();

            Console.WriteLine("Digite o primeiro número: ");
            string? input02 = Console.ReadLine();

            // verificar se está nulo ou vázio
            if (string.IsNullOrWhiteSpace(input01) || string.IsNullOrWhiteSpace(input02))
            {
                Console.WriteLine("Por favor, digite numeros válidos!");
            }

            // converter de string para int
            else if (int.TryParse(input01, out int numero01) && int.TryParse(input02, out int numero02))
            {
                int soma = numero01 + numero02;

                Console.WriteLine($"O resultado da soma é: {soma}");
            }
        }
    }
}
