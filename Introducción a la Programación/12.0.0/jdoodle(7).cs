using System;

class Program
{
    
    public static void ejemploMatrices(){
        int [,] notas = new int[6,30];
        // filas = materias
        //columnas = alumnos
        // llenando matriz
        for (int f =0; f<6; f++){
            for (int c = 0; c<30; c++){
                notas[f,c] = f+c;
            }
        }
        
        //mostrar matriz
        for (int f =0; f<6; f++){
            for (int c = 0; c<30; c++){
                Console.Write(" f:"+f+" c:"+c+"="+notas[f,c]);
                
            }
            Console.WriteLine();
        }
        //mostrar solo las notas de un estudiante 
        int estudiante;
        Console.WriteLine("Ingrese numero de estudiante ");
        try{
            
        
            estudiante = int.Parse(Console.ReadLine());
            if (estudiante >0 && estudiante <= 30){
                Console.WriteLine("Notas del estudiante "+estudiante);
                for (int f=0; f<6;f++ ){
                    Console.WriteLine("Nota "+notas[f,estudiante-1]);
                }
                
            }else{
                Console.WriteLine("ERROR> hay 30 estudiantes");
            }
        }catch{
            Console.WriteLine("ERROR> debe ser un numero");
        }
        
        
    }
    static void Main() {
        ejemploMatrices();
    }
}