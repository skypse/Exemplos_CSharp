using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_24
{
    internal class Pratica_24
    {
        public static void Main(string[] args)
        {
        // Condição Simples:
            // Exemplo01
            int x = 20;
            int y = 18;

            if (x > y) 
            {
                Console.WriteLine("20 é maior que 18");
            }

            // Exemplo02
            if (30 > 18)
            {
                Console.WriteLine("30 é maior que 18");
            }

        // Condição Composta:
            // Exemplo01
            int time01 = 20;
            if (time01 < 18)
            {
                Console.WriteLine("BOM DIA!");
            }
            else
            {
                Console.WriteLine("BOA NOITE!");
            }

        // Condição Encadeada:
            // Exemplo01
            int time02 = 22;
            if (time02 < 10)
            {
                Console.WriteLine("BOM DIA!");
            }
            else if (time02 < 20)
            {
                Console.WriteLine("BOA TARDE!");
            }
            else
            {
                Console.WriteLine("BOA NOITE!");
            }

            // ShortHand (if ternário)
            // Exemplo01 = variable = (condition) ? expressionTrue :  expressionFalse;
            int time03 = 20;
            string result = (time03 < 18) ? "BOM DIA!" : "BOA NOITE!";
        }
    }
}
