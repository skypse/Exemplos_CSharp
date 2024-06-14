using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_53
{
    internal class Pratica_53
    {
        public static void Main(string[] args)
        {
            int[] meusNumeros = {1,8,4,6,95,10};
            Console.WriteLine(meusNumeros.Max()); // seleciona o maior
            Console.WriteLine(meusNumeros.Min()); // seleciona o menor
            Console.WriteLine(meusNumeros.Sum()); // soma dos inteiros
        }
    }
}
