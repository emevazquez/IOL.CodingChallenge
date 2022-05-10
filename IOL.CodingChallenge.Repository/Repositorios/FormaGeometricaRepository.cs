using IOL.CodingChallenge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOL.CodingChallenge.Repository.Repositorios
{
    public class FormaGeometricaRepository : IFormaGeometricaRepository
    {
        public void AgregarForma(FormaGeometrica forma)
        {
           // var formas = new List<FormaGeometrica>();
           var formas = ObtenerFormas().ToList();
            formas.Add(forma);
        }

        public void Calcular(FormaGeometrica forma)
        {
            var area = (decimal)0.00;
            var perimetro = (decimal)0.00;

           
            Console.WriteLine("Area de la forma geometrica" + forma.calcularArea());
            Console.WriteLine("Perimetro de la forma geometrica" + forma.calcularPerimetro());


            if (forma is Circulo)
            {
               // forma.calcularArea
                var circle = forma as Circulo;

                perimetro = circle.calcularPerimetro();
                area =circle.calcularArea();
                Console.WriteLine("Area de Circulo" + area);
                Console.WriteLine("Perimetro de Circulo" + perimetro);
                //  forma.calcularPerimetro() as Circulo;
            }
            else
            if (forma is Cuadrado)
            {
                var square = forma as Cuadrado;
                perimetro = square.calcularPerimetro();
                 area =  square.calcularArea();
                Console.WriteLine("Area de Cuadrado" + area);
                Console.WriteLine("Perimetro de Cuadrado" + perimetro);
            }
            else
            if (forma is TrianguloEquilatero)
            {
                var triangle = forma as TrianguloEquilatero;
                perimetro = triangle.calcularPerimetro();
                area = triangle.calcularArea();
                Console.WriteLine("Area de TrianguloEquilatero" + area);
                Console.WriteLine("Perimetro de TrianguloEquilatero" + perimetro);

            }
            else
            if (forma is Rectangulo)
            {
                var rectangle = forma as Rectangulo;
                perimetro = rectangle.calcularPerimetro();
                area = rectangle.calcularArea();
                Console.WriteLine("Area de Rectangulo" + area);
                Console.WriteLine("Perimetro de Rectangulo" + perimetro);

            }
            else
            if (forma is Trapecio)
            {
                var trapecio = forma as Trapecio;
               perimetro = trapecio.calcularPerimetro();
            area = trapecio.calcularArea();
                Console.WriteLine("Area de Trapecio" + area);
                Console.WriteLine("Perimetro de Trapecio" + perimetro);

            }
            else
            {
                throw new Exception("No reconozco la forma");
            }
                    
        }

        public IEnumerable<FormaGeometrica> ObtenerFormas()
        {
            var formas = new List<FormaGeometrica>();
            formas.Add(new Circulo
            {
                lado = (decimal)10
            }) ;

            formas.Add(new Cuadrado
            {
                lado = (decimal)4
            });

            formas.Add(new TrianguloEquilatero
            {
                lado = (decimal)5
            });
                       formas.Add(new Trapecio());
            formas.Add(new Rectangulo());
          
            formas.Add(new Cuadrado
            {
                lado = (decimal)3
            });

            return formas;
        }
    }
}
