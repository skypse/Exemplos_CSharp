using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_66
{
    internal class Pratica_66
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A divisão total ficou: {Divisao(numero1, numero2)}");
        }
        static double Divisao(double n1, double n2)
        {
            return n1 / n2;
        }
    }
}
