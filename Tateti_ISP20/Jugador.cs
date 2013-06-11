using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace Tateti_ISP20
{
    public class Jugador
    {
        // declaracion de las propiedades.
        //diccionario de fichas.
        public Hashtable fichas;
        public string tipo_ficha;
        //metodo constructor de la clase.
        public Jugador(string tipoficha)
        {
            //inicializamos las fichas.
            fichas = new Hashtable();
            // define que el jugador tiene 1 ficha y es de posicion 0.
            fichas.Add(1,0);
            // define que el jugador tiene 2 fichas y es de posicion 0.
            fichas.Add(2,0);
            // define que el jugador tiene 3 fichas y es de posicion 0.
            fichas.Add(3,0);
            tipo_ficha = tipoficha;
        }
    }
}
