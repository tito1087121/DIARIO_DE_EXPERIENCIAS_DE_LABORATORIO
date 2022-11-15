using System;

class Program
{
    public static double conversionMoneda(double quetzales){
        double dolares = quetzales / 7.8;
        return dolares;
    }
    
    
    static void Main() {
    /* 
        double d = conversionMoneda(100);
        Console.WriteLine(d);
      */
      
      int cant = 0;
      double q,d;
      while (cant < 5)
      {
          Console.WriteLine("Ingrese quetzales ");
          q = Double.Parse(Console.ReadLine());
          d = conversionMoneda(q);
          Console.WriteLine("En dolares "+d.ToString("$0.##"));
          cant++;
      }
      
    }
}