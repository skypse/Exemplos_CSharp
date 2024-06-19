using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_56
{
    internal class Pratica_56
    {
        public static void Main(string[] args)
        {
            // 2D Array
            int[,] numeros = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            foreach (int i in numeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}
