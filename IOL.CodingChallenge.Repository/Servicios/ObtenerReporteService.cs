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
            var numeroRectangulos = 0m;
            var numeroTrapecios = 0m;

            var areaCuadrados = 0m;
            var areaCirculos = 0m;
            var areaTriangulos = 0m;
            var areaRectangulos = 0m;
            var areaTrapecios = 0m;

            var perimetroCuadrados = 0m;
            var perimetroCirculos = 0m;
            var perimetroTriangulos = 0m;
            var perimetroRectangulos = 0m;
            var perimetroTrapecios = 0m;
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
                else report += "";
            }
            if (numeroCuadrados>0)
            {
                string forma = translate.Square;
                if (numeroCuadrados>1)
                {
                    forma += "s";
                }
                report += $"{numeroCuadrados} " +
                    $"{forma} | Area {(areaCuadrados):#.##} | {translate.Perimetro}  {perimetroCuadrados:#.##} <br/>";

            }
            if (numeroTriangulos > 0)
            {
                string forma = translate.Triangle;
                if (numeroTriangulos > 1)
                {
                    forma += "s";
                }
                report += $"{numeroTriangulos} " +
                    $"{forma} | Area {(areaTriangulos):#.##} | {translate.Perimetro}  {perimetroTriangulos:#.##} <br/>";

            }

            if (numeroCirculos > 0)
            {
                string forma = translate.Circle;
                if (numeroCirculos > 1)
                {
                    forma += "s";
                }
                report += $"{numeroCirculos} " +
                    $"{forma} | Area {(areaCirculos):#.##} | {translate.Perimetro}  {perimetroCirculos:#.##} <br/>";

            }
            if (numeroTrapecios > 0)
            {
                string forma = translate.Trapeze;
                if (numeroCirculos > 1)
                {
                    forma += "s";
                }
                report += $"{numeroTrapecios} " +
                    $"{forma} | Area {(areaTrapecios):#.##} | {translate.Perimetro}  {perimetroTrapecios:#.##} <br/>";

            }
            report += translate.Total +  (numeroCirculos + numeroCuadrados + numeroTriangulos + numeroTrapecios ).ToString()  +" "+ translate.Formas;
            report += translate.Perimetro + " " +  (perimetroCirculos + perimetroCuadrados + perimetroTriangulos).ToString() + " Area " +
                (areaCirculos + areaCuadrados + areaTriangulos).ToString();


            return report;
        }
    }
}
