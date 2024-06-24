using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_75
{
    class Program
    {
        // sem construtor
        public static void Main(string[] args)
        {
            Aluno Freitas = new Aluno();
            Freitas.nome = "Freitas";
            Freitas.idade = "19";
            Freitas.jogoFavorito = "Minecraft";

            Aluno Isaac = new Aluno();
            Isaac.nome = "Isaac";
            Isaac.idade = "18";
            Isaac.jogoFavorito = "R6";

            Console.WriteLine($"Nome: {Isaac.nome} Idade:{Isaac.idade}  Jogo Favorito:{Isaac.jogoFavorito}");
            Console.WriteLine($"Nome: {Freitas.nome} Idade:{Freitas.idade}  Jogo Favorito:{Freitas.jogoFavorito}");
        }
    }
}
