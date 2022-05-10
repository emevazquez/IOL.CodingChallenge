using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOL.CodingChallenge.Model
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        public override decimal calcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
        }


        public override decimal calcularPerimetro()
        {
            return (decimal)lado *3;
        }
    }
}
