using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tateti_ISP20
{
    public class Juego
    {
        private Tablero tablero;
        private Jugador jugador1;
        private Jugador jugador2;

        public Juego()
        {
            tablero = new Tablero();
            jugador1 = new Jugador("X");
            jugador2 = new Jugador("0");
        }
        public void PintarTablero()
        {
            tablero.Limpiar();
            // estamos recorriendo las fichas del jugador uno tomando los valores de cada una de las posiciones de las fichas
            //ficha es de tipo dictionariEntry(entrada de diccionario)
            foreach (DictionaryEntry ficha in jugador1.fichas)
            {
                //imprime el tipo de ficha del jugador 1
                tablero.posiciones[ficha.Value] = jugador1.tipo_ficha+ficha.Key.ToString();
            }
            // estamos recorriendo las fichas del jugador uno tomando los valores de cada una de las posiciones de las ficha
            foreach (DictionaryEntry ficha in jugador2.fichas)
            {
                //imprime el tipo de ficha del jugador 2
                tablero.posiciones[ficha.Value] = jugador2.tipo_ficha+ficha.Key.ToString();
            }
            //tablero.Marcar(jugador, pos_elegida)
            {
                // llamamos al metodo pintar
            }
            tablero.Pintar();
        }
        public int SeleccionarFicha (int jugador_actual)
    
        {
               int ficha_a_mover = 0;
               Console.Write("Jugador {0}: Ingrese el nro de ficha a mover: ", jugador_actual);
               //obtenemos una variable llamada posicion elegida
               // toma esa posicion y la convierte en entera
               try
               {
                ficha_a_mover = Convert.ToInt32(Console.ReadLine());
               }
               catch
               {
               Console.WriteLine("Error: Valor incorrecto, presione una tecla para continuar");
               Console.ReadKey();
               SeleccionarFicha(jugador_actual);
              }
               return ficha_a_mover;
        }
        public void Jugar(int jugador, int nroficha, int pos_elegida)
        {
            // si jugador es =  a 1:
            if ( jugador == 1)
                // graba en la ficha del jugador cual es la posicion que puede elegir.
                jugador1.fichas[nroficha] = pos_elegida ;
            else
                jugador2.fichas[nroficha] = pos_elegida;
           
        }
    }
}
