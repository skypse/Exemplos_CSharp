using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_79
{
    class Program
    {
        public static void Main(string[] args)
        {
            Carro BYD = new Carro();
            BYD.Modelo = "Dolphin";
            BYD.Ano = 2025;
            Console.WriteLine(BYD.Modelo);
            Console.WriteLine(BYD.Ano);
        }
    }
}
