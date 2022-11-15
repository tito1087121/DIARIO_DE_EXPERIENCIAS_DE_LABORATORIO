using System;

namespace Totito
{
    class Program
    {
        public static string[,] tablero = new string[3, 3];
        // El jugador uno sera "x"
        // El jugador uno sera "O"
        public static void totito(int jugador, int fila, int columna)
        {
            Console.WriteLine("");
            Console.WriteLine("Juego creado por José Roberto Rodríguez // 1087121");
            Console.WriteLine("");
            string p = "";
            if (jugador == 1)
            {
                p = "x";
            }
            else if (jugador == 2)
            {
                p = "O";
            }
            else
            {
                p = "O";
            }
            if (tablero[fila, columna] == "")
            {
                tablero[fila, columna] = p;
            }
            else
            {
                Console.WriteLine("Esta posición ya esta ocupada");

            }
        }
        //Se muestra el tablero del juego
        public static void Tablero()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(tablero[i, c] + " | ");
                }
                Console.WriteLine();
            }
        }
        // Se inicia el tablero de juego
        public static void iniciarTablero()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int c = 0; c < 3; c++)
                {
                    tablero[i, c] = "";
                }
            }
            Console.WriteLine();
        }

        //si devuelve 1 o 2 es el jugador si devuelve 0 nadie ganó
        //evaluar vertical
        public static int evaluación()
        {
            for (int f = 0; f < 2; f++)
            {
                if (tablero[f, 0] == tablero[f, 1] && tablero[f, 1] == tablero[f, 2])
                {
                    if (tablero[f, 0] == "x")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
                if (tablero[0, 0] == tablero[1, 1] && tablero[1, 1] == tablero[2, 2])
                {
                    if (tablero[0, f] == "x")
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
            return 0;
        }
        static void Main(string[] args)
        {

            iniciarTablero();
            totito(1, 0, 0);
            Tablero();
            totito(1, 0, 1);
            Tablero();
            totito(1, 0, 2);
            Tablero();
            totito(2, 1, 1);
            Tablero();
            Console.Clear();
            totito(2, 1, 2);
            Tablero();
            int ganador = evaluación();
            Console.WriteLine("El ganador del juego es: " + ganador);
            Console.ReadKey();
        }

    }
}
