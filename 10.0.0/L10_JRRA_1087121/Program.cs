using System;

namespace L10_JRRA_1087121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Programa realizado por José Roberto Rodríguez // 1087121");
            Console.WriteLine("");
            string u, c;
            int intentos = 0;
            bool ingresar;
            while (intentos < 3)
            {
                Console.WriteLine("");
                Console.WriteLine("Ingrese el nombre de usuario, por favor");
                Console.WriteLine("");
                u = Console.ReadLine();
                Console.WriteLine("");
                Console.WriteLine("Ingrese la contraseña del usuario, por favor");
                Console.WriteLine("");
                c = Console.ReadLine();
                ingresar = Login(u, c);
                if (ingresar == true) 
                {
                    intentos = 3;
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("Usted ha ingresado, bienvenido!");
                }
                else
                {
                    intentos++;
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("Usuario o contraseña incorrecto, por favor ingrese de nuevo sus datos");
                    Console.WriteLine("");
                }
            }
            static bool Login (string u, string c)
            {
                if (u == "usuario1" && c == "asdasd")
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
