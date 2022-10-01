using System;

namespace L5_JRRA_10871321
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ejercicio 1");
            Console.WriteLine("José Roberto Rodríguez // 1087121");
            Console.WriteLine("");

            Console.WriteLine("Ingrese un número entero");
            Console.WriteLine("");
            int x;
            x = Convert.ToInt32(Console.ReadLine());

            if (x > 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Resultado: Positivo");
            }
            if (x < 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Resultado: Negativo");
            }
            if (x == 0)
            {
                Console.WriteLine("");
                Console.WriteLine("Resultado: Cero");
            }
        }
}
}
