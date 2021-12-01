using Maquina_de_cafe;
using NUnit.Framework;

namespace TDD_Test
{
    public class TestMaquinaDeCafe
    {
        Cafetera cafetera;
        Vaso vasosPequeno;
        Vaso vasosMediano;
        Vaso vasosGrande;
        Azucarero azucarero;
        Maquina_de_Cafe maquinaDeCafe;
        
        [SetUp]
        public void setUp()
        {
            cafetera = new Cafetera(50);
            vasosPequeno = new Vaso(5, 10);
            vasosMediano = new Vaso(5, 20);
            vasosGrande = new Vaso(5, 30);
            azucarero = new Azucarero(20);

            maquinaDeCafe = new Maquina_de_Cafe();
            maquinaDeCafe.setCafetera(cafetera);
            maquinaDeCafe.setVasosPequeno(vasosPequeno);
            maquinaDeCafe.setVasosMediano(vasosMediano);
            maquinaDeCafe.setVasosGrande(vasosGrande);
            maquinaDeCafe.setAzucarero(azucarero);
        }

        [Test]
        public void deberiaDevolverUnVasoPequeno()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            Assert.AreEqual(maquinaDeCafe.vasosPequenos, vaso);
        }

        [Test]
        public void deberiaDevolverUnVasoMediano()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("mediano");
            Assert.AreEqual(maquinaDeCafe.vasosMedianos, vaso);
        }

        [Test]
        public void deberiaDevolverUnVasoGrande()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("grande");
            Assert.AreEqual(maquinaDeCafe.vasosGrandes, vaso);
        }

        [Test]
        public void deberiaDevolverNoHayVasos()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 10, 2);
            Assert.AreEqual("No hay Vasos", resultado);
        }

        [Test]
        public void deberiaDevolverNoHayCafe()
        {
            cafetera = new Cafetera(5);
            maquinaDeCafe.setCafetera(cafetera);
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso,1,2);
            Assert.AreEqual("No hay Cafe", resultado);
        }

        [Test]
        public void deberiaDevolverNoHayAzucar()
        {
            azucarero = new Azucarero(2);
            maquinaDeCafe.setAzucarero(azucarero);
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("No hay Azucar", resultado);
        }

        [Test]
        public void deberiaRestarCafe()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.getCafetera().getCantidadDeCafe();
            Assert.AreEqual(40, resultado);
        }

        [Test]
        public void deberiaRestarVaso()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.getVasosPequenos().getCantidadVasos();
            Assert.AreEqual(4, resultado);
        }

        [Test]
        public void deberiaRestarAzucar()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            int resultado = maquinaDeCafe.getAzucarero().getCantidadDeAzucar();
            Assert.AreEqual(17, resultado);
        }

        [Test]
        public void deberiaDevolverFelicitaciones()
        {
            Vaso vaso = maquinaDeCafe.getTipoVaso("pequeno");
            string resultado = maquinaDeCafe.getVasoDeCafe(vaso, 1, 3);
            Assert.AreEqual("Felicitaciones", resultado);
        }

    }
}
