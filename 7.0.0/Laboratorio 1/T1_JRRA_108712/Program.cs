using System;

namespace T1_JRRA_108712
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Mi segundo programa");
            Console.WriteLine("");

            Console.WriteLine("Ingrese su nombre: ");
            Console.WriteLine("");
            string sNombre = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Ingrese su edad: ");
            Console.WriteLine("");
            string sEdad = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Ingrese su carrera: ");
            Console.WriteLine("");
            string sCarrera = Console.ReadLine();

            Console.WriteLine("");
            Console.WriteLine("Ingrese su número de carnet: ");
            Console.WriteLine("");
            string sCarné = Console.ReadLine();
            Console.WriteLine("");

            Console.WriteLine("Soy " + sNombre + " tengo " + sEdad + " años y estudio la carrera de " + sCarrera + ". Mi número de carnet es: " + sCarné);

            Console.ReadKey();
        }
    }
}
