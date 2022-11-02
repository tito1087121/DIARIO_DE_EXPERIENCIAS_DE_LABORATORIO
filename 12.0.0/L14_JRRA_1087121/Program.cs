using System;

namespace L14_JRRA_1087121
{
    class Program
    {
        static void Main(string[] args)
        {
            int menu = 0;

            Console.WriteLine("");
            Console.WriteLine("Ingrese el número de la opción que desea realizar");
            Console.WriteLine("");
            Console.WriteLine("1. Calcular la edad para 5 empleados");
            Console.WriteLine("2. Salarios a pagar para 5 empleados");
            Console.WriteLine("3. Salir del menú");
            Console.WriteLine("");
            menu = int.Parse(Console.ReadLine());

            switch (menu)
            {
                case 1:
                    string[] n = new string[5];
                    int[] e = new int[5];
                    int[] op = new int[5];
                    
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el nombre del empleado");
                        Console.WriteLine("");
                        n[i] = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese en el año que nacio " + n[i]);
                        Console.WriteLine("");
                        e[i] = int.Parse(Console.ReadLine());
                        op[i] = 2022 - e[i];
                    }
                    Console.WriteLine("");
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine(n[i] + " tiene " + op[i] + " años.");
                        Console.WriteLine("");
                    }
                    break;

                case 2:
                    string[] p = new string[5];
                    double[] s = new double[5];
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el puesto de la persona");
                        Console.WriteLine("");
                        p[i] = Console.ReadLine();
                        Console.WriteLine("");
                        Console.WriteLine("Ingrese el salario de la persona " + p[i]);
                        Console.WriteLine("");
                        s[i] = double.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < 5; i++)
                    {
                        Console.WriteLine("");
                        Console.WriteLine("El puesto dentro de la empresa denominado " + p[i] + " tiene un salario de: " + s[i]);
                        Console.WriteLine("");
                    }
                    break;

                case 3:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Debe ingresar una opción entre el número 1 y 3");
                    Console.WriteLine("");
                    break;
            }    
                
        }
    }
}
