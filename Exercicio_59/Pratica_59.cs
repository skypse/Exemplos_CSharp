using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_59
{
    internal class Pratica_59
    {
        public static void Main(string[] args)
        {
            Equipe("isaac", 2);
            Equipe("gean", 2);
            Equipe("carlinhos", 2);
        }

        static void Equipe(string nome, int numeroEquipe)
        {
            Console.WriteLine($"{nome} pertence a equipe {numeroEquipe}");
        }
    }
}
