using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOL.CodingChallenge.Model
{
    public class Circulo : FormaGeometrica
    {
        public Circulo(decimal l)
        {
            this.lado = (decimal)l;
        }
       public override decimal calcularArea()
        {
            return (decimal)Math.PI * (lado / 2) * (lado / 2);
        }


        public override decimal calcularPerimetro()
        {
            return (decimal)Math.PI * lado;
        }
    }
}
