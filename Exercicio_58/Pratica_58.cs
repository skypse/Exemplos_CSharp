using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_58
{
    internal class Pratica_58
    {
        static void MeuMetodo(string fname)
        {
            Console.WriteLine($"{fname} Amaral");
        }

        static void Main(string[] args)
        {
            MeuMetodo("Gabriel");
            MeuMetodo("Gean");
            MeuMetodo("isaac");
        }
    }
}
