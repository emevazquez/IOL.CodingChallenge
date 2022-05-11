using IOL.CodingChallenge.Model;
using System.Collections.Generic;

namespace IOL.CodingChallenge.Repository.Servicios
{
     interface IObtenerReporteService
    {
        public string Imprimir(List<FormaGeometrica> formas, int idioma);
    }
}