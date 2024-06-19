using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_63
{
    internal class Pratica_63
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite o primeiro valor: ");
            double numero1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite o segundo valor: ");
            double numero2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A soma total ficou: {Somar(numero1, numero2)}");
        }
        static double Somar(double n1, double n2)
        {
            return n1 + n2;
        }
    }
}
