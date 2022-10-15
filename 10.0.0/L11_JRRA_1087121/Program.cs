using System;

namespace L11_JRRA_1087121
{
    class Program
    {
        static void Main(string[] args)
        {
            double cambio = 0;
            Console.WriteLine("Programa hecho por José Roberto Rodríguez // 1087121");
            Console.WriteLine("");
            Console.WriteLine("Ingrese la opción que desea realizar");
            Console.WriteLine("");
            Console.WriteLine("1. De libras a euros");
            Console.WriteLine("2. De dolares a euros");
            Console.WriteLine("3. De yenes a euros");
            Console.WriteLine("");
            cambio = double.Parse(Console.ReadLine());
            Console.ReadKey();
            ConversionMoneda(cambio);
        }

        static void ConversionMoneda(double cambio)
        {
            double libra = 1.22, dolar = 0.75, yen = 0.009, clibra = 0, rlibra = 0, cdolar = 0, rdolar = 0, cyen = 0, ryen = 0;
            switch (cambio)
            {
                case 1:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de libras para convertir a euros");
                    clibra = double.Parse(Console.ReadLine());
                    rlibra = clibra * libra;
                    Console.WriteLine("");
                    Console.WriteLine("El cambio a euros es de; " + rlibra);
                    Console.WriteLine("");
                    break;

                case 2:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de dolar para convertir a euros");
                    Console.WriteLine("");
                    cdolar = double.Parse(Console.ReadLine());
                    rdolar = cdolar * dolar;
                    Console.WriteLine("");
                    Console.WriteLine("El cambio a euros es de; " + rdolar);
                    Console.WriteLine("");
                    break;

                case 3:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese la cantidad de libras para convertir a euros");
                    Console.WriteLine("");
                    cyen = double.Parse(Console.ReadLine());
                    ryen = cyen * yen;
                    Console.WriteLine("");
                    Console.WriteLine("El cambio a euros es de; " + ryen);
                    Console.WriteLine("");
                    break;

                default:
                    Console.WriteLine("");
                    Console.WriteLine("Ingrese una opción válida");
                    break;

            }

        }
   
    }
}
