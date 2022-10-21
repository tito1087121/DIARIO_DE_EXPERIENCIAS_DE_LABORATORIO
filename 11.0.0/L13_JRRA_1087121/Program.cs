using System;

namespace L13_JRRA_1087121
{
    class Program
    {
        static void Main(string[] args)
        {
            Nombres nombre = new Nombres();
            nombre.ver();
            nombre.Mostrar();
        }
        class Nombres
        {
            private string[] n;
            private int[] e;
            public int edad = 0;
            public void ver()
            {
                n = new string[5];
                e = new int[5];
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese un nombre");
                    Console.WriteLine("");
                    string x;
                    x = Console.ReadLine();
                    n[i] = x;
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la edad de la persona");
                    Console.WriteLine("");
                    string edad;
                    edad = Console.ReadLine();
                    e[i] = int.Parse(edad);
                }   
             }
        

        public void Mostrar()
            {
                for (int m =0; m < 5; m++)
                {
                    if (e[m] >= 18)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(n[m] + " es mayor de edad");
                        Console.WriteLine("");
                    }   
                    else
                    {
                        Console.WriteLine();
                    }   
            }
                Console.ReadKey();
        }
    }
}
}
