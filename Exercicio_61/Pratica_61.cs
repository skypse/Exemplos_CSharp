using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_61
{
    internal class Pratica_61
    {
        public static void Main(string[] args)
        {
            NomePlayer();
            NomePlayer("Isaac", 9);
        }

        static void NomePlayer(string nomePlayer = "Guilherme Freitas", int itens = 1284172835)
        {
            int numeroIten = NumeroIten(itens);
            Console.WriteLine($"{nomePlayer} possui {numeroIten} itens");
        }

        static int NumeroIten(int itens)
        {
            return itens;
        }
    }
}
