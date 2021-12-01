using Maquina_de_cafe;
using NUnit.Framework;

namespace TDD_Test
{
    public class TestAzuquero
    {
        Azucarero azuquero;

        [SetUp]
        public void Setup()
        {
            azuquero = new Azucarero(10);
        }

        [Test]
        public void deberiaDevolverVerdaderoSiHaySuficienteAzucarEnElAzuquero()
        {
            bool resultado = azuquero.hasAzucar(5);
            Assert.AreEqual(resultado, true);
            resultado = azuquero.hasAzucar(10);
            Assert.AreEqual(resultado, true);
        }

        [Test]
        public void deberiaDevolverFalsoPorqueNoHaySuficienteAzucarEnElAzuquero()
        {
            bool resultado = azuquero.hasAzucar(15);
            Assert.AreEqual(resultado, false);
        }

        [Test]
        public void deberiaRestarAzucarAlAzuquero()
        {
            azuquero.giveAzucar(5);
            Assert.AreEqual(5, azuquero.getCantidadDeAzucar());
            azuquero.giveAzucar(2);
            Assert.AreEqual(3, azuquero.getCantidadDeAzucar());
        }
    }
}
