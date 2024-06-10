using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_22
{
    internal class Pratica_22
    {
        public static void Main(string[] args)
        {
            // Exemplo01
            string agradecimento1 = "Olá";
            string agradecimento2 = "Prazer em conhece-lo";
            Console.WriteLine(agradecimento1);
            Console.WriteLine(agradecimento2);

            // Exemplo02
            string txtTeste = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            Console.WriteLine("A quantidade de letras no txtTeste é: "+ txtTeste.Length);

            // Exemplo03
            string txt = "Hello World";
            Console.WriteLine(txt.ToUpper()); // "HELLO WORLD"
            Console.WriteLine(txt.ToLower()); // "hello world"
        }
    }
}
