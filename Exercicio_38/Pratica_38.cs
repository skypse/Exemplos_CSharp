using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_38
{
    internal class Pratica_38
    {
        public static void Main(string[] args)
        {
            // Exemplo Foreach

            string []carro = {"Uno", "Apolo", "Kwid", "206"};
            foreach (string contadora in carro)
            {
                Console.WriteLine(contadora);
            }
        }
    }
}
