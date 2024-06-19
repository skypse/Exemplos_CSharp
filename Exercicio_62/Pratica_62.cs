using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_62
{
    internal class Pratica_62
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Subtrair (6, 5));
            Console.WriteLine(Somar(6, 5));
        }
        static int Somar(int n1, int n2)
        {
            return n1 + n2;
        }
        static int Subtrair(int n1, int n2)
        {
            return n1 - n2;
        }
    }
}
