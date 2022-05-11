using IOL.CodingChallenge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOL.CodingChallenge.Repository.Servicios
{
    public class ObtenerReporteService : IObtenerReporteService
    {
        public string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            string report = "";
            int total = formas.Count();
            Idioma idioma1 = new();
            Idioma x = idioma1;
            var translate = x.Obtener(idioma);

            var numeroCuadrados = 0;
            var numeroCirculos = 0;
            var numeroTriangulos = 0;

            var areaCuadrados = 0m;
            var areaCirculos = 0m;
            var areaTriangulos = 0m;

            var perimetroCuadrados = 0m;
            var perimetroCirculos = 0m;
            var perimetroTriangulos = 0m;
            foreach (var f in formas)
            {
                if (f is Circulo)
                {
                    numeroCirculos++;
                    areaCirculos += f.calcularArea();
                    perimetroCirculos += f.calcularPerimetro();

                }
                if(f is TrianguloEquilatero)
                {
                    numeroTriangulos++;
                    areaTriangulos += f.calcularArea();
                    perimetroTriangulos += f.calcularPerimetro();
                }
                if (f is Cuadrado)
                {
                    numeroCuadrados++;
                    areaCuadrados += f.calcularArea();
                    perimetroCuadrados += f.calcularPerimetro();
                }
                else report += "<br>Forma Desconocida";
            }

            return report;
        }
    }
}
