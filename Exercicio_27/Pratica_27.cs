using System;

namespace Exercicio_26
{
    internal class Pratica_26
    {
        public static void Main(string[] args)
        {
            // Exercicio01
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Programa que contém uma lista de meses numeradas do 1 ao 12");
            Console.WriteLine("1 = Janeiro, 2 = Fevereiro, 3 = Março");
            Console.WriteLine("4 = Abril, 5 = Maio, 6 = Junho");
            Console.WriteLine("7 = Julho, 8 = Agosto, 9 = Setembro");
            Console.WriteLine("10 = Outubro, 11 = Novembro, 12 = Dezembro.");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Escreva um número de 1 a 12: ");
            string? inputMes = Console.ReadLine();

            // Checando se está vazio
            if (string.IsNullOrWhiteSpace(inputMes))
            {
                Console.WriteLine("Não pode haver campos nulos!");
                return;
            }

            // Convertendo string para int
            if (int.TryParse(inputMes, out int numeroMes))
            {
                if (numeroMes < 1 || numeroMes > 12)
                {
                    Console.WriteLine("Digite um número inteiro válido entre 1 e 12");
                }
                else
                {
                    // Switch para o mês
                    switch (numeroMes)
                    {
                        case 1:
                            Console.WriteLine("Janeiro");
                            break;
                        case 2:
                            Console.WriteLine("Fevereiro");
                            break;
                        case 3:
                            Console.WriteLine("Março");
                            break;
                        case 4:
                            Console.WriteLine("Abril");
                            break;
                        case 5:
                            Console.WriteLine("Maio");
                            break;
                        case 6:
                            Console.WriteLine("Junho");
                            break;
                        case 7:
                            Console.WriteLine("Julho");
                            break;
                        case 8:
                            Console.WriteLine("Agosto");
                            break;
                        case 9:
                            Console.WriteLine("Setembro");
                            break;
                        case 10:
                            Console.WriteLine("Outubro");
                            break;
                        case 11:
                            Console.WriteLine("Novembro");
                            break;
                        case 12:
                            Console.WriteLine("Dezembro");
                            break;
                        default:
                            Console.WriteLine("Número inválido. Por favor, digite um número de 1 a 12.");
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Digite um número inteiro válido!");
            }
        }
    }
}
