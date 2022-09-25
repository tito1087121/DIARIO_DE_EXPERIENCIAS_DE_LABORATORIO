using System;

namespace L1_JRRA_1087121
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese su nombre: ");
            String Nombre = Console.ReadLine();

            Console.WriteLine(""); 
            Console.WriteLine("Hola Mundo ");
            Console.WriteLine("soy " + Nombre);
            Console.WriteLine("");

            //La diferencia entre writeline y write es que con la instrucción writeline se deja una línea de por medio entre
            //cada línea de instrucción y con write no deja ningun espacio entre las líneas de instrucción y muestra todas juntas. 

            Console.Write("Hola Mundo ");
            Console.Write("soy " + Nombre);
            Console.ReadKey();

            // El proyecto es un compilador porque es un programa que traduce un programa escrito en lenguaje fuente

            //Análisis

            // Entradas: Preguntar el nombre
            // Procesos: Guardar el nombre en una variable para después mostrarlo
            // Salidas: Mostrar el nombre con writeline y write

             
        }
    }
}
