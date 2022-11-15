using System;

class Program
{
    static void Main() {
     string[] parqueo = new string[4];
     for (int i=0; i<4; i++){
         Console.WriteLine("indice: "+i);
         Console.WriteLine(parqueo[i]);
     }
     
     parqueo[2] = "P45DNL";
     
     
     for(int i=0; i<4; i++){
         Console.WriteLine("Ingrese la placa");
         parqueo[i] = Console.ReadLine();
     }

     for (int i=0; i<4; i++){
         Console.WriteLine("indice> "+i);
         Console.WriteLine(parqueo[i]);
     }
     
     
     Console.WriteLine("Fin del programa");


    }
}