using System;

namespace Exercicio_36
{
    internal class Pratica_36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Digite os minutos para serem inseridos: ");
            int minutos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite os segundos para serem inseridos: ");
            int segundos = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Temporizador iniciando:");

            // minutos
            for (int m = 0; m <= minutos; m++)
            {
                // segundos
                for (int s = 0; s <= segundos; s++)
                {
                    Console.WriteLine("Tempo decorrido: " + m + " minutos " + s + " segundos");
                    //Thread.Sleep(400); // dorme por 400 milisegundos
                }
            }

            Console.WriteLine("Temporizador encerrado");
        }
    }
}
