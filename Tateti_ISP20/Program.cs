using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tateti_ISP20
{
    class Program
    {
        static void Main(string[] args)
        {
            //se crea un objeto de la clase juego.
            Juego juego = new Juego();
            //creamos dos variables jugador_actual y ficha_actual.
            int jugador_actual = 1;
            int ficha_actual = 1;
            int ficha_a_mover = 0;
            int posicion_elegida = 0;

            while (true)
            {
                // llama al metodo de pintar tablero ren la clase juego.
                juego.PintarTablero();
                //cuando ya se colocaron las 6 fichas 
                //pide definir la ficha a mover.
                if (ficha_actual == 0)
                {
                        ficha_a_mover = juego.SeleccionarFicha(jugador_actual);
                        Console.Write("Jugador {0}: Ingrese la posición de la ficha {1}: ", jugador_actual, ficha_a_mover);
                        posicion_elegida = Convert.ToInt32(Console.ReadLine());
                        juego.Jugar(jugador_actual, ficha_a_mover, posicion_elegida);
                }
                   
                    //en las primeras 6 fichas se ejecuta
                    //esto
                 else
                {
                    //pide ingresar el movimiento
                    Console.Write("Jugador {0}: Ingrese la posición de la ficha {1}: ", jugador_actual, ficha_actual);
                    //obtenemos una variable llamada posicion elegida
                    // toma esa posicion y la convierte en entera
                    posicion_elegida = Convert.ToInt32(Console.ReadLine());
                    // almacena el movimiento en el tablero y en las fichas del jugador
                    juego.Jugar(jugador_actual, ficha_actual, posicion_elegida);
                    //cabio de jugador
                
                }
            
                jugador_actual++;
              // si jugador_actual es igual a 3 que vuelve a 1.
                if (jugador_actual == 3) 
                {
                    jugador_actual = 1;
                    if (ficha_actual > 0)
                    {
                        ficha_actual++;
                        // incrementa uno en la ficha. cuando ficha actual es igual a 4 lo hace 0.
                        if (ficha_actual == 4)
                            ficha_actual = 0;
                    }
                }
            }
            //Console.ReadLine();
        }
    }
}
