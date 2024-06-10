using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_26
{
    internal class Pratica_26
    {
        public static void Main(string[] args) 
        {
            // Exercicio01
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Programa que contém uma lista de dias numeradas do 1 à 7");
            Console.WriteLine("1 = Segunda-Feira, 2 = Terça-Feira ,3 = Quarta-Feira");
            Console.WriteLine("4 = Quinta-Feira, 5 = Sexta-Feira ,6 = Sabado");
            Console.WriteLine("7 = Domingo.");
            Console.WriteLine("-----------------------------------------------------------------------");
            Console.WriteLine("Escreva um número de 1 à 7: ");
            string? inputDia = Console.ReadLine();

            // Checando se está vazio
            if (string.IsNullOrWhiteSpace(inputDia))
            {
                Console.WriteLine("Não pode haver campos nulos!");
                return;
            }

            // Convertendo string para int
            if (int.TryParse(inputDia, out int numerodia))
            {
                if (numerodia < 1 || numerodia > 7)
                {
                    Console.WriteLine("Digite um número inteiro válido");
                }
                else
                {
                    // Switch para o dia
                    switch (numerodia)
                    {
                        case 1:
                            Console.WriteLine("Segunda-Feira");
                            break;
                        case 2:
                            Console.WriteLine("Terça-Feira");
                            break;
                        case 3:
                            Console.WriteLine("Quarta-Feira");
                            break;
                        case 4:
                            Console.WriteLine("Quinta-feira");
                            break;
                        case 5:
                            Console.WriteLine("Sexta-Feira");
                            break;
                        case 6:
                            Console.WriteLine("Sabado");
                            break;
                        case 7:
                            Console.WriteLine("Domingo");
                            break;
                        default:
                            Console.WriteLine("Número inválido. Por favor, digite um número de 1 a 7.");
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
