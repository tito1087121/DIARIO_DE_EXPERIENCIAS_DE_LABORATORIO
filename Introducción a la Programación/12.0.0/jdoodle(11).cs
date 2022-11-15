using System;

class Program
{
     public static string[,] tablero = new string[3,3];
    
    // jugador 1 = x
    // jugador 2 = o
    public static void jugar(int numJugador, int fila, int col){
        string pieza = "";
        if (numJugador == 1){
            pieza = "x";
        }else {
            pieza = "o";
        }
        
        if (tablero[fila,col] == "" ){
            tablero[fila,col] = pieza;    
        }else{
            Console.WriteLine("Posicion ya esta ocupada");
        }
        //evaluar ganador
        int res  = evaluar();
        if (res != 0 ){
         Console.WriteLine("El ganador es "+res);    
        }
        
        
    }
    
    // mostrar tablero
    public static void mostrarTablero(){
        for (int f = 0; f<3; f++){
            for (int c =0; c<3; c++){
                Console.Write(tablero[f,c]+" |  ");
                
            }
            Console.WriteLine();
        }
    }
        // inicializar el tablero
    public static void iniciarTablero(){
        for (int f = 0; f<3; f++){
            for (int c =0; c<3; c++){
               tablero[f,c] = "";
                
            }
            Console.WriteLine();
        }
    }
    // si devuelve 1 o 2 es el jugador si devuelve 0 nadie gano
    public static int evaluar(){
        //evalua horizontal
        for (int f =0; f<3;f++){
                if (tablero[f,0] == tablero[f,1] && tablero[f,1] == tablero[f,2] ){ // si son iguales
                    if (tablero[f,0] == "x"){ // evalua cual
                      return  1;    
                    }else if (tablero[f,0] == "o"){
                        return 2;
                    }
                    
                }
        }
        
        // evaluar vertical
         for (int c =0; c<3;c++){
                if (tablero[0,c] == tablero[1,c] && tablero[1,c] == tablero[2,c] ){ // si son iguales
                    if (tablero[0,c] == "x"){ // evalua cual
                      return  1;    
                    }else if (tablero[0,c] == "o"){
                        return 2;
                    }
                    
                }
        }
        
        //diagonal 
        if (tablero[0,0] == tablero[1,1] && tablero[1,1] == tablero[2,2]){
                if (tablero[0,0] == "x"){ // evalua cual
                  return  1;    
                }else if (tablero[0,0] == "o"){
                    return 2;
                }
        }
        
           if (tablero[2,0] == tablero[1,1] && tablero[1,1] == tablero[0,2]){
                if (tablero[1,1] == "x"){ // evalua cual
                  return  1;    
                }else if (tablero[1,1] == "o"){
                    return 2;
                }
        }
        return 0;
    }
    
    static void Main() {
        iniciarTablero();
        jugar(1,0,0);
        //mostrarTablero();
        jugar(2,1,1);
        jugar(1,0,1);
        jugar(2,1,2);
        jugar(1,0,2);
        
        mostrarTablero();
   
        
    }
    
}