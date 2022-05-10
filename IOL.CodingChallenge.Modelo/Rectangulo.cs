using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOL.CodingChallenge.Model
{
    public class Rectangulo : FormaGeometrica
    {
        public decimal altura;

        public Rectangulo(decimal altura)
        {
            this.altura = altura;
            this.lado = lado;
        }
        public Rectangulo()
        {
            this.lado = (decimal)3;
            this.altura = (decimal)6;
        }

        public override decimal  calcularArea()
        {
            return (decimal)lado*altura;
        }


        public override decimal calcularPerimetro()
        {
            return (decimal)lado*2 + altura*2;
        }
    }
}
