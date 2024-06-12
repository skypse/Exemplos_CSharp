using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_29
{
    internal class Pratica_29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite um número que deseja saber a tabuada: ");
            int numero = Convert.ToInt32(Console.ReadLine());

            int contadora = 1;

            while (contadora < 11)
            {
                Console.WriteLine(numero + " X " + contadora + " = " + (numero * contadora));
                contadora++;
            }
        }
    }
}
