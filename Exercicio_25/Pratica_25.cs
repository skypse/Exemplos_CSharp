using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_25
{
    internal class Pratica_25
    {
        public static void Main(string[] args)
        {
            // Exemplo Switch Case;
            // Exemplo01
            int day = 4;
            switch (day)
            {
                case 1:
                    Console.WriteLine("Segunda-Feira");
                    break;
                    case 2:
                    Console.WriteLine("Terça-Feira");
                    break;
                    case 3:
                    Console.WriteLine("Quarta-Feira");
                    break;
                    case 4:
                    Console.WriteLine("Quinta-feira");
                    break;
                    case 5:
                    Console.WriteLine("Sexta-Feira");
                    break;
                    case 6:
                    Console.WriteLine("Sabado");
                    break;
                    case 7:
                    Console.WriteLine("Domingo");
                    break;
            }
        }
    }
}
