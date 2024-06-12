using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_30
{
    internal class Pratica_30
    {
        public static void Main(string[] args)
        {
            int contador = 1;
            int acumuladora = 0;

            while (contador < 101)
            {
                acumuladora += contador;
                contador++;
            }
            Console.WriteLine(acumuladora);
        }
    }
}
