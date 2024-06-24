using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_76
{
    class Program
    {
        public static void Main(string[] args)
        {
            Jogo EldenRing = new Jogo("Elden Ring", "RPG eletrônico de ação", 2022);
            Jogo DarkSouls = new Jogo("Dark Souls", "RPG eletrônico de ação", 2011);

            Console.WriteLine($"Nome: {EldenRing.nome} Genero: {EldenRing.genero}  Ano Lançamento:{EldenRing.anoLancamento}");
            Console.WriteLine($"Nome: {DarkSouls.nome} Genero: {DarkSouls.genero}  Ano Lançamento:{DarkSouls.anoLancamento}");
        }
    }
}
