using IOL.CodingChallenge.Repository.Repositorios;
using System;

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
            
          FormaGeometricaRepository f = new FormaGeometricaRepository();
            var text = f.ObtenerFormas();
            foreach (var item in text)
            {
                f.Calcular(item);
            }
            
           // Console.WriteLine("Hello World!" + text);
           // Console.WriteLine(args );

        }
    }
}
