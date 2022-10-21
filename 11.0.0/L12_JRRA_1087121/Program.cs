using System;

namespace L12_JRRA_1087121
{
    class Program
    {
        static void Main(string[] args)
        {
            Puntos pn = new Puntos();
            pn.d();
            pn.Mostrar();
        }
        class Puntos
        {
            private int[] n;
            public int s = 0;
            public int c = 0;
            public int prom = 0;
            public void d()
            {
                n = new int[15];
                for (int i = 0; i < 15; i++)
                {
                    if (n[i] <= 100)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese una nota menor o igual a 100");
                        Console.WriteLine("");
                        string x;
                        x = Console.ReadLine();
                        n[i] = int.Parse(x);
                        s += n[i];
                        prom = s / 15;
                    }
                else
                {
                        Console.WriteLine("");
                        Console.WriteLine("ERROR - Debes ingresar una nota que sea menor o igual a 100, por favor");
                        Console.WriteLine("");
                    }
            }
        }
        public void Mostrar()
        {
            for (int i = 0; i < 15; i++)
            {
                    Console.WriteLine("");
                    Console.WriteLine("Su nota es: " +n[i]);
                    Console.WriteLine("");
                }
                Console.WriteLine("");
                Console.WriteLine("La suma total de las notas es de: " + s);
                Console.WriteLine("");
                Console.WriteLine("El promedio de las notas es de: " + prom);
                Console.WriteLine("");
                Console.ReadKey();
        }
    }
}
}

