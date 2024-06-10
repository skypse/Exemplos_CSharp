using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_23
{
    internal class Pratica_23
    {
        public static void Main(string[] args)
        {
            // Exemplo01
            string primeiroNome1 = "Gabriel ";
            string segundoNome1 = "do Amaral";
            string nomeCompleto1 = primeiroNome1 + segundoNome1;
            Console.WriteLine(nomeCompleto1);

            // Exemplo02
            string primeiroNome2 = "Gabriel ";
            string segundoNome2 = "do Amaral";
            string nomeCompleto = string.Concat(primeiroNome2 + segundoNome2);

            // Exemplo03 
            int x1 = 10;
            int y1 = 20;
            int z1 = x1 + y1; // vai ser 30 (int)

            // Exemplo04
            string x2 = "10";
            string y2 = "20";
            string z2 = x2 + y2; // vai ser 1020 (string)

            // Exemplo05
            string primeiroNome3 = "Gabriel";
            string segundoNome3 = "do Amaral";
            string nomeCompleto3 = $"Meu nome completo é: {primeiroNome3} {segundoNome3}";
            Console.WriteLine(nomeCompleto3);

            // Exemplo06
            string meuTexto01 = "Hello";
            Console.WriteLine(meuTexto01[0]); // saída = 'H'

            // Exemplo07
            string meuTexto02 = "Hello";
            Console.WriteLine(meuTexto02[1]); // saída = 'e'

            // Exemplo08
            string meuTexto03 = "Hello";
            Console.WriteLine(meuTexto03.IndexOf("e")); // saída '1'

            // Exemplo09

            // Nome Completo
            string meuTexto04 = "Gabriel do Amaral";

            // Localização da letra 'D'
            int charPos = meuTexto04.IndexOf("A");

            // Pegar o Ultimo Nome
            string ultimoNome = meuTexto04.Substring(charPos);

            // Mostrando o resultado
            Console.WriteLine(ultimoNome);

            // Exemplo10
            string txt01 = "Nós somos \"Vikings\" diretamente do norte";
            Console.WriteLine(txt01);

            // Exemplo11
            string txt02 = "It\'s alright";
            Console.WriteLine(txt02);

            // Exemplo12
            string txt03 = "Este Caracter é chamado de \\ backslash";
            Console.WriteLine(txt03);

            // Exemplo13
            string txt04 = "Hello\nWorld!";
            Console.WriteLine(txt04);

            // Exemplo14
            string txt05 = "Hello\tWorld";
            Console.WriteLine(txt05);

            // Exemplo15
            string txt06 = "Hello\blo World!";
            Console.WriteLine(txt06);
        }
    }
}
