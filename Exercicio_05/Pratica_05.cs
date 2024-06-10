using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_05
{
    internal class Pratica_05
    {
        public static void Main(string[] args)
        {
            int meuInteiro = 12;
            double meuDouble = 2.25;
            bool meuBoolean = false;

            Console.WriteLine(Convert.ToString(meuInteiro)); // int para string
            Console.WriteLine(Convert.ToDouble(meuInteiro)); // int para double
            Console.WriteLine(Convert.ToInt32(meuDouble)); // double para int
            Console.WriteLine(Convert.ToString(meuBoolean)); // bool para string
        }
    }
}
