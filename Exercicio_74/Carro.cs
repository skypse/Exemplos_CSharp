using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio_74
{
    internal class Carro
    {
        public string nomeCarro;
        public string modeloCarro;
        public int anoCarro;
        public string corCarro;
        public string combustivelCarro;
        public Carro(string nomeDoCarro, string modeloDoCarro, int anoDoCarro, string corDoCarro, string combustivelDoCarro)
        {
            nomeCarro = nomeDoCarro;
            modeloCarro = modeloDoCarro;
            anoCarro = anoDoCarro;
            corCarro = corDoCarro;
            combustivelCarro = combustivelDoCarro;
        }
        public static void Main(string[] args)
        {
            Carro byd = new Carro("BYD", "Dolphin", 2025, "vermelho", "eletrico");
            Console.WriteLine(" O nome do carro é : " + byd.nomeCarro);
            Console.WriteLine(" O modelo do carro é : " + byd.modeloCarro);
            Console.WriteLine(" O ano do carro é : " + byd.anoCarro);
            Console.WriteLine(" A cor do carro é : " + byd.corCarro);
            Console.WriteLine(" O combustível do carro é : " + byd.combustivelCarro);
        }
    }
}
