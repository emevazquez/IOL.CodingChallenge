using IOL.CodingChallenge.Model;
using IOL.CodingChallenge.Modelo.ServicioReporte;
using NUnit.Framework;
using System.Collections.Generic;

namespace IOL.CodingChallenge.TestsSuite
{
    [TestFixture]
    public class TestsSuite
    {
        [SetUp]
        public void Setup()
        {
        }     
       
            [TestCase]
            public void TestResumenListaVacia()
            {
            ReporteService servicioReporte = new ReporteService(); 
                Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                    servicioReporte.Imprimir(new List<FormaGeometrica>(),1));
            }

            [TestCase]
            public void TestResumenListaVaciaFormasEnIngles()
            {
            ReporteService servicioReporte = new ReporteService();

            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                    servicioReporte.Imprimir(new List<FormaGeometrica>(),2));
            }

            [TestCase]
            public void TestResumenListaConUnCuadrado()
            {
                var cuadrados = new List<FormaGeometrica> { new Cuadrado(5) };
            ReporteService servicioReporte = new ReporteService();

            var resumen = servicioReporte.Imprimir(cuadrados,1);
                Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
            }

            [TestCase]
            public void TestResumenListaConMasCuadrados()
            {
                var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado (5),
                new Cuadrado (1),
                new Cuadrado (3)
            };

            ReporteService servicioReporte = new ReporteService();
            var resumen = servicioReporte.Imprimir(cuadrados,2);

                Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
            }

            [TestCase]
            public void TestResumenListaConMasTipos()
            {
            ReporteService servicioReporte = new ReporteService();

            var formas = new List<FormaGeometrica>
            {
                new Cuadrado (5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m)
            };

                var resumen = servicioReporte.Imprimir(formas,2);

                Assert.AreEqual(
                    "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13,01 | Perimeter 18,06 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 97,66 Area 91,65",
                    resumen);
            }

            [TestCase]
            public void TestResumenListaConMasTiposEnCastellano()
            {
            ReporteService servicioReporte = new ReporteService();
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado (5),
                new Circulo (3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new TrianguloEquilatero (9),
                new Circulo (2.75m),
                new TrianguloEquilatero (4.2m)
            };


            var resumen = servicioReporte.Imprimir(formas,1);

                Assert.AreEqual(
                    "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 13,01 | Perimetro 18,06 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 97,66 Area 91,65",
                    resumen);
            }
        }
}