using System;

namespace L15_JRRA_1087121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");
            Console.WriteLine("José Roberto Rodríguez // 1087121");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("Este programa sumara elementos positivos y negativos en una matriz de 40 x 50");
            Console.WriteLine("");

            int[,] matriz = new int[40, 50];
            int st = 0;
            Random r = new Random();

            for (int x = 0; x < 40; x++)
            {
                for (int y = 0; y < 50; y++)
                {
                    matriz[x, y] = r.Next(-100, 50);
                }
            }
            for (int x = 0; x < 40; x++)
            {
                for (int y = 0; y < 50; y++)
                {
                    Console.Write(" " + matriz[x, y]);
                    st += matriz[x, y];
                }
                Console.WriteLine();
            }
            Console.WriteLine("");
            Console.WriteLine("El resultado de la matriz es de: " + st);
            Console.WriteLine("");
            Console.ReadKey();
        }
    }
}
