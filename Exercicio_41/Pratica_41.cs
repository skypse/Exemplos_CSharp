using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_41
{
    internal class Pratica_41
    {
        public static void Main(string[] args)
        {
            string[] nomes = { "Jailson", "Amaral", "Johny Dudu", "isaac" };
            foreach (string s in nomes)
            {
                if (s == "isaac")
                {
                    break;
                }
                Console.WriteLine(s);
            }
        }
    }
}
