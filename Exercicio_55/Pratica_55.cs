using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_55
{
    internal class Pratica_55
    {
        public static void Main(string[] args)
        {
            // Exemplo Matriz (Array 2D)
            int[,] numeros = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            numeros[0, 0] = 9; // mudar o valor 1, para 9
            Console.WriteLine(numeros[0, 0]); // mostrar 9 invez de 1
        }
    }
}
