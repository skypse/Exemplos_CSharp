using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_70
{
    internal class Aluno
    {
        string nome = "Freitas";
        int idade = 19;
        string habilidade = "Jogar um mine";
        bool louco = true;

        public static void Main(string[] args)
        {
            Aluno freitas = new Aluno();
            Console.WriteLine(freitas.habilidade);

            Aluno isaac = new Aluno();
            isaac.nome = "isaac";
            isaac.habilidade = "Jogar vava";
            Console.WriteLine(isaac.habilidade);
        }
    }
}
