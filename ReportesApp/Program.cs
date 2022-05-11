using IOL.CodingChallenge.Model;
using IOL.CodingChallenge.Repository.Repositorios;
using IOL.CodingChallenge.Repository.Servicios;
using System;
using System.Collections.Generic;

namespace ReportesApp
{
    public class Program
    {
        IFormaGeometricaRepository formas;
        public Program( IFormaGeometricaRepository f)
        {
            formas = f;
           // var x = EscribirData();

           // string[] y = null;

            //y.SetValue(x,0);
           // Main(y);
        }
        public string EscribirData()
        {
            var form = formas.ObtenerFormas().ToString();

           return formas.ObtenerFormas().ToString();
           
        }
        static void Main(string[] args)
        {

            ObtenerReporteService repo = new ObtenerReporteService();
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado( 5),
                new Circulo ( 3),
                new TrianguloEquilatero (4),
                new Cuadrado (2),
                new TrianguloEquilatero( 9),
                new Circulo(2.75m),
                new TrianguloEquilatero( 4.2m)
            };



            var r = repo.Imprimir(formas, 1);
            Console.Write(r);
            Console.Write("---------------------");
            var x = repo.Imprimir(formas, 2);
            Console.Write(x);
            // Console.WriteLine("Hello World!" + text);
            // Console.WriteLine(args );

        }
    }
}
