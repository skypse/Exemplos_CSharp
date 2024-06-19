using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_68
{
    internal class Pratica_68
    {
        // utilizando a sobrecarga
        public static void Main(string[] args)
        {
            int meuNumero01 = Somar(8, 5);
            double meuNumero02 = Somar(2.5, 5.5);
            Console.WriteLine($"Int: {meuNumero01}");
            Console.WriteLine($"Double: {meuNumero02}");
        }
        static int Somar(int x, int y)
        {
            return x + y;
        }

        static double Somar(double x, double y)
        {
            return x + y;
        }
    }
}
