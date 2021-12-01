using Maquina_de_cafe;
using NUnit.Framework;

namespace TDD_Test
{
    public class TestVaso
    {
            
        [Test]
        public void deberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasosPequenos=new Vaso(2,10);
            bool resultado = vasosPequenos.hasVasos(1);

            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void deberiaDevolverFalsoSiNoExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(2,10);
            bool resultado = vasosPequenos.hasVasos(2);

            Assert.AreEqual(true, resultado);
        }

        [Test]
        public void deberiaRestarCantidadDeVaso()
        {
            Vaso vasospequeño = new Vaso(5, 10);
            vasospequeño.giveVasos(1);

            Assert.AreEqual(4, vasospequeño.getCantidadVasos());
        }

    }
}
