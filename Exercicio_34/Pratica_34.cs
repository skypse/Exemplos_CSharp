using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_34
{
    internal class Pratica_34
    {
        public static void Main(string[] args) 
        {
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Fora Loop: {i}");
                for (int j = 1; j <= 3; j++)
                {
                    Console.WriteLine($"Dentro do loop: {j}");
                }
            }
        }
    }
}
