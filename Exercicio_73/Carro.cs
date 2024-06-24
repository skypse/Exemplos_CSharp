using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_73
{
    class Carro
    {
        public string cor;

        public Carro(string corDoCarro)
        {
            cor = corDoCarro;
        }

        public static void Main(string[] args)
        {
            Carro BYD = new Carro("Preto Fosco");
            Console.WriteLine($"A cor do BYD é: {BYD.cor}");
        }
    }
}
