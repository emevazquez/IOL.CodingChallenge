using IOL.CodingChallenge.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOL.CodingChallenge.Model
{
    public class Idioma
    {  // public int id { get; set; }
        public string ListaVacia { get; set; }
        public string Titulo { get; set; }
        public string Total { get; set; }
        public string Formas { get; set; }
        public string Perimetro { get; set; }
        public string Circle { get; set; }
        public string Square { get; set; }
        public string Triangle { get; set; }
        public string Trapeze { get; set; }
        public string Rectangle { get; set; }
     


        public  Idioma Obtener(int id)
        {
            if (id==1)
            {
                return new Spanish();
            }
            if (id == 2)
            {
                return new Ingles();

            }
            else
            {
                return new Italiano();

            }
        }
     
        
    }


}
