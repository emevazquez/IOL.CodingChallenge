using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOL.CodingChallenge.Model
{
    public class Trapecio :FormaGeometrica
    {
        public decimal ladoMayor;
        public decimal ladoMenor;
        public decimal baseMayor;
        public decimal baseMenor;
        public Trapecio(decimal ladoM, decimal ladoMe, decimal baseUno, decimal baseDos)
        {
            if (lado>ladoM)
            {
                ladoMayor = lado;
                ladoMenor = ladoMe;
            }
            else
            {
                ladoMenor = lado;
                ladoMayor = ladoM;
            }

            if (baseUno>baseDos)
            {
                baseMayor = baseUno;
                baseMenor = baseDos;

            }
            else
            {
                baseMayor = baseDos;
                baseMenor = baseUno;

            }

            if (ladoMayor!=ladoMenor && baseMayor==baseMenor)
            {
                throw new Exception("Matematicamente imposible tener un trapecio de estas dimensiones");
            }
        }
        public Trapecio()
        {
            this.baseMayor = (decimal)3;
            this.baseMenor = (decimal)2;
            this.ladoMenor= (decimal)3;
            this.ladoMayor= (decimal)4;
        }

        public override decimal calcularArea()
        {
            return (decimal)(baseMayor + baseMenor) * ladoMayor / 2;
        }


        public override decimal calcularPerimetro()
        {
            return (decimal)baseMayor + baseMenor + ladoMayor + ladoMenor;
        }
    }
}
