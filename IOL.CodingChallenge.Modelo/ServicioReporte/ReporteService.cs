using IOL.CodingChallenge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOL.CodingChallenge.Modelo.ServicioReporte
{
   public class ReporteService
    {
        public string Imprimir(List<FormaGeometrica> formas, int idioma)
        {
            

            int total = formas.Count();
            Idioma idioma1 = new Idioma();
            Idioma x = idioma1;
            Idioma translate;
            string idiomaNoSoportado = "";
            if (idioma > 3)
            {
                 translate = x.Obtener(1);
                idiomaNoSoportado = "Idioma no soportado, reporte en español.<br> ";
            }
            else
            {
                 translate = x.Obtener(idioma);

            }
            string report = idiomaNoSoportado+ translate.Titulo ;
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

            

            if (total == 0)
            {
                report = translate.ListaVacia;
                return report;
            }
            foreach (var f in formas)
            {


   if(f.GetType().ToString() == "IOL.CodingChallenge.Model.FormaGeometrica")
                  
                    report += "Forma de lado " + f.lado + " desconocida";

             
            if(f is Circulo)
                {
                    numeroCirculos++;
                areaCirculos += f.calcularArea();
                perimetroCirculos += f.calcularPerimetro();

            }
            if (f is TrianguloEquilatero)
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


            //else 
            //{  }
        }
            if (numeroCuadrados > 0)
            {
                string forma = translate.Square;
                if (numeroCuadrados > 1)
                {
                    forma += "s";
                }
                report += $"{numeroCuadrados} " +
                    $"{forma} | Area {areaCuadrados:0.##} | {translate.Perimetro} {perimetroCuadrados:0.##} <br/>";

            }

            if (numeroCirculos > 0)
            {
                string forma = translate.Circle;
                if (numeroCirculos > 1)
                {
                    forma += "s";
                }
                report += $"{numeroCirculos} " +
                    
                    $"{forma} | Area {Math.Round(areaCirculos,2)} | {translate.Perimetro} {Math.Round(perimetroCirculos,2)} <br/>";

            }

            if (numeroTriangulos > 0)
            {
                string forma = translate.Triangle;
                if (numeroTriangulos > 1)
                {
                    forma += "s";
                }
                report += $"{numeroTriangulos} " +
                
                    $"{forma} | Area {Math.Round(areaTriangulos,2)} | {translate.Perimetro} {Math.Round(perimetroTriangulos,2)} <br/>";


            }

            if (numeroTrapecios > 0)
            {
                string forma = translate.Trapeze;
                if (numeroCirculos > 1)
                {
                    forma += "s";
                }
                report += $"{numeroTrapecios} " +
                        $"{forma} | Area { Math.Round(areaTrapecios,2)} | {translate.Perimetro} {Math.Round(perimetroTrapecios,2)} <br/>";

            }
            if (numeroRectangulos > 0)
            {
                string forma = translate.Rectangle;
                if (numeroRectangulos > 1)
                {
                    forma += "s";
                }
                report += $"{numeroRectangulos} " +
                    $"{forma} | Area {Math.Round(areaRectangulos,2)} | {translate.Perimetro} {Math.Round(perimetroRectangulos,2)} <br/>";

            }
            report += translate.Total + (numeroCirculos + numeroCuadrados + numeroTriangulos + numeroTrapecios).ToString() + " " + translate.Formas;
            report += " "+ translate.Perimetro + " " + Math.Round((perimetroCirculos + perimetroCuadrados + perimetroTriangulos),2).ToString() + " Area " +
                Math.Round((areaCirculos + areaCuadrados + areaTriangulos),2).ToString();


            return report;
        }
    }
}
