using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_60
{
    internal class Pratica_60
    {
        static void Main(string[] args)
        {
            Game();
            Game("Isaac", "R6");
        }
        static void Game(string pessoaNome = "Guilherme Freitas", string jogos = "Minecraft")
        {
            Console.WriteLine($"{pessoaNome} joga {jogos}");
        }
    }
}
