using Maquina_de_cafe;
using NUnit.Framework;

namespace TDD_Test
{
    public class TestCafetera
    {
        [Test]
        public void deberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(5);
            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void deberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);
            bool resultado = cafetera.hasCafe(11);
            Assert.AreEqual(false, resultado);
        }

        [Test]
        public void deberiaRestarCafeAlaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);
            cafetera.giveCafe(7);
            Assert.AreEqual(3, cafetera.getCantidadDeCafe());
        }
    }
}
