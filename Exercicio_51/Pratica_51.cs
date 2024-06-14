using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_51
{
    internal class Pratica_51
    {
        public static void Main(string[] args)
        {
            // Exemplo Array.Sort em string (Ordem Alfabética)
            string[] nomes = { "Gabriel", "João", "isaac", "Gean", "Ana Luiza" };
            Array.Sort(nomes);
            foreach (string n in nomes)
            {
                Console.WriteLine(n);
            }
        }
    }
}
