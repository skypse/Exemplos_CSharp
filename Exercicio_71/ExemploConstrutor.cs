using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_71
{
    internal class ExemploConstrutor
    {
        public string modelo;

        public ExemploConstrutor()
        {
            modelo = "Mustang";
        }

        public static void Main(string[] args)
        {
            ExemploConstrutor Ford = new ExemploConstrutor();
            Console.WriteLine($"O modelo do carro é: {Ford.modelo}");  

        }
    }
}
