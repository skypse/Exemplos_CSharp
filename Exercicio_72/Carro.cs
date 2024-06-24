using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_72
{
    class Carro
    {
        public string modelo;

        public Carro()
        {
            modelo = "DOLPHIN";
        }

        public static void Main(string[] args)
        {
            Carro BYD = new Carro();
            Console.WriteLine($"O modelo do carro é: {BYD.modelo}");
        }
    }
}
