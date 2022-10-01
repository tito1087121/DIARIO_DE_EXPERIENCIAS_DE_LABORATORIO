using System;

namespace L5_2_JRRA_1087121
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia;
            Console.WriteLine("");
            Console.WriteLine("Ejercicio 2");
            Console.WriteLine("");
            Console.WriteLine("José Roberto Rodríguez // 1087121");
            Console.WriteLine("");
            Console.WriteLine("Identificación de día de la semana por medio de un número");
            Console.WriteLine("");
            Console.WriteLine("Ingrese un número entre el 1 y 7");
            dia = Convert.ToInt32(Console.ReadLine());

            if (dia == 1)
                Console.WriteLine("Día: lunes");
            else
            {
                if (dia == 2)
                    Console.WriteLine("Día: martes");
                else
                {
                    if (dia == 3)
                        Console.WriteLine("Día: miércoles");
                    else
                    {
                        if (dia == 4)
                            Console.WriteLine("Día: jueves");
                        else
                        {
                            if (dia == 5)
                                Console.WriteLine("Día: viernes");
                            else
                            {
                                if (dia == 6)
                                    Console.WriteLine("Día: sábado");
                                else
                                {
                                    if (dia == 7)
                                        Console.WriteLine("Día: domingo");
                                    else
                                    {
                                        if (dia > 7)
                                            Console.WriteLine("Ingrese un número valido");
                                        else
                                        {
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
