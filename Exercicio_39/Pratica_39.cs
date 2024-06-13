using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_39
{
    internal class Pratica_39
    {
        public static void Main(string[] args)
        {
            string[] nome = { "C#", "Java", "Python", "SQLServer" };
            foreach (string contadora in nome)
            {
                Console.WriteLine(contadora);
            }
        }
    }
}
