using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOL.CodingChallenge.Model
{
    //CLASE PADRE DE LA QUE HEREDAN TODAS LAS FORMAS
    public  class FormaGeometrica
    {
       // public int tipo { get; set; }
        public decimal lado { get; set; }

      

        //public decimal perimetro { get; set; }
        //public decimal area { get; set; }

        public virtual decimal calcularArea()
        {
            return lado * lado;

        }

        public virtual decimal calcularPerimetro()
        {
            return lado + lado;
        }
    }
}
