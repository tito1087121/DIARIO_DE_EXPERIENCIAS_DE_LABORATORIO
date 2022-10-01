using System;

namespace L7_JRRA_1087121
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Laboratorio 07 // 1087121");
                Console.WriteLine("");
                Console.WriteLine("Ingrese un número entero");
                Console.WriteLine("");
                int x = 1, y = 0, a = 1, b = 0, numero;
                numero = int.Parse(Console.ReadLine());
                Console.WriteLine("");
                Console.WriteLine("La serie Fibonacci es:");
                Console.WriteLine("");
                Console.WriteLine("0");
                while (true)
                {
                    if (b >= numero)
                    {
                        break;
                    }
                    Console.WriteLine(a);
                    a = x + y;
                    y = x;
                    x = a;
                    b++;
                }
                Console.ReadKey();
            }
            catch
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese un número entero");
                Console.ReadKey();
            }
    }
}
}
