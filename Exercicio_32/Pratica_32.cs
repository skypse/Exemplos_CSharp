using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_32
{
    internal class Pratica_32
    {
        public static void Main(string[] args)
        {
            int contadora = 1;
            int acumuladora = 0;
            do
            {
                if (contadora % 2 == 0) 
                {
                    acumuladora += contadora;
                }
                contadora++;
            } while (contadora < 501);
            Console.WriteLine("A soma dos números pares é: " + acumuladora);
        }
    }
}
