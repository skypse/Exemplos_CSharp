using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_52
{
    internal class Pratica_52
    {
        public static void Main(string[] args)
        {
            // Exemplo Array.Sort em inteiros (Ordem crescente)
            int[] meusNumeros = {50,34,23,12,10,8,2,1};
            Array.Sort(meusNumeros);
            foreach (int i in meusNumeros)
            {
                Console.WriteLine(i);
            }
        }
    }
}
