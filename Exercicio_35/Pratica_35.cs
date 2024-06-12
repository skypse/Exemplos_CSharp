using System;

namespace Exercicio_35
{
    internal class Pratica_35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Cronômetro iniciando:");

            // minutos
            for (int minutos = 0; minutos < 60; minutos++)
            {
                // segundos
                for (int segundos = 0; segundos < 60; segundos++)
                {
                    Console.WriteLine("Tempo decorrido: " + minutos + " minutos " + segundos + " segundos");
                }
            }

            Console.WriteLine("Cronômetro encerrado");
        }
    }
}
