using System;
using System.Collections.Generic;
using System.Text;

namespace Libreria.Business
{
    public class Reservas
    {
        public int GetReserva() {
            Boolean estado = false;

            string mensaje = "Error en grupo {1}";
            string conclusion = String.Format(mensaje,"Error 1");
            int valorReserva = 0;
            if (valorReserva < 0)
            {
                new ArgumentException("valorReserva must be nonnegative");
            }

            if (estado) {

                return 0;
            }
            else { 
                return 1;
            }
            return 5;
        }
    }
}
