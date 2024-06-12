using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_31
{
    internal class Pratica_31
    {
        public static void Main(string[] args)
        {
            int contadora = 15;
            do
            {
                Console.WriteLine(contadora * contadora);
                contadora++;
            } while (contadora < 201);
        }
    }
}
