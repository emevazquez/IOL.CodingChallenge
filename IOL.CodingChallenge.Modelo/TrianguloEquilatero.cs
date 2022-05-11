using System;

namespace IOL.CodingChallenge.Model
{
    public class TrianguloEquilatero : FormaGeometrica
    {

        public TrianguloEquilatero(decimal l)
        {
            this.lado = l;
        }
        public override decimal calcularArea()
        {
            return ((decimal)Math.Sqrt(3) / 4) * lado * lado;
        }


        public override decimal calcularPerimetro()
        {
            return (decimal)lado * 3;
        }
    }
}
