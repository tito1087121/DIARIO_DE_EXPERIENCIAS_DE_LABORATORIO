using System;

class Program
{
    static void Main() {
    int[] notas = new int[5];
    string[] nombres = new string[5];
    
    nombres[10] = "Maria";
    for(int i=0; i<5;i++){
        Console.WriteLine("Ingrese nombre de estudiante");
        nombres[i] = Console.ReadLine();
        Console.WriteLine("Ingrese nota ");
        notas[i] = int.Parse(Console.ReadLine());
    }
  
    double promedio = 0;
    double suma = 0;
    for(int i=0; i<5; i++){
        suma = suma + notas[i];
    }
    
    promedio = suma / 5;
    Console.WriteLine("Promedio "+promedio);
    
    Console.WriteLine("Estudiantes sobre el promedio ");
    for(int i=0; i<5; i++){
        if (notas[i] > promedio){
            Console.WriteLine(nombres[i]);
        }
        
    }
    
  
  
    }
}