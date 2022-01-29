using Libreria.Business;
using NUnit.Framework;

namespace Pruebas
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestReserva()
        {
            Reservas reservas = new Reservas();
            int rta = reservas.GetReserva();
            Assert.That(
               rta == 1, "No se obtivo la respuesta esperada");
               


           //Assert.Pass();
        }
    }
}