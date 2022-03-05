using Libreria.Business;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace xTests.PruebasUnitarias
{
    public class TestReserva
    {

        //public void Setup()
        //{
        //}

        [Fact]
        public void PruebaReserva()
        {
            Reserva reservas = new Reserva();
            int rta = reservas.GetReserva();
            Assert.Equal(expected: 1, rta);
            //"No se obtivo la respuesta esperada");
            
        }
    }
}
