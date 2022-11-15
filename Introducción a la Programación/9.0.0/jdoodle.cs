using System;

class Program
{
    
    //funcion
    public static int alCuadrado()
    {
        int num;
        int res;
        
        Console.WriteLine("ingrese el numero");
        num = Int32.Parse(Console.ReadLine());
        res = num * num;
        
        return res;
    }
    
    // recibir de parametro el numero a evauar
    public static int alCuadradoV2(int num)
    {
        int res;
        res = num * num;
        
        return res;   
    }
    
    
    //bloque que se ejecuta
    static void Main() {
       int num2;
       int resultado = alCuadrado();
       int num3 = 15;
       Console.WriteLine("El resultado es  "+resultado);
       Console.WriteLine("Version 2");
      
      //1 
       resultado = alCuadradoV2(5);
       Console.WriteLine("El resultado es  "+resultado);
       
       //2
       Console.WriteLine("Ingrese el numero");
       num2 = Int32.Parse(Console.ReadLine());
       resultado = alCuadradoV2(num2);
       Console.WriteLine("El resultado es  "+resultado);
      //3
       resultado = alCuadradoV2(num3);
       Console.WriteLine("El resultado es  "+resultado);
       
       
       
    }
}