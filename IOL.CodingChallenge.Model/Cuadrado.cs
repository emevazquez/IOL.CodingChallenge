using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOL.CodingChallenge.Model
{
    public class Cuadrado : FormaGeometrica
    {
        public override decimal calcularArea()
        {
            return (decimal)lado  * lado;
        }


        public override decimal calcularPerimetro()
        {
            return (decimal) lado * 4;
        }
    }
}
