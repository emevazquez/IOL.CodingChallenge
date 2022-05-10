using IOL.CodingChallenge.Model;
using NUnit.Framework;

namespace IOL.CodingChallenge.TestsSuite
{
    public class TestsSuite
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test()]
        public void Test1()
        {
            Assert.Pass();
            var ciculo = new Circulo();
            ciculo.lado = 35;

            var cuadrado = new Cuadrado();
            cuadrado.lado = 35;

            Assert.AreNotEqual(ciculo.calcularPerimetro(), cuadrado.calcularPerimetro());
        }
    }
}