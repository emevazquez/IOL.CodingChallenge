using IOL.CodingChallenge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOL.CodingChallenge.Modelo
{
    public class Ingles : Idioma
    {
        public Ingles()
        {
            Titulo = "<h1>Shapes report</h1>";
            ListaVacia = "<h1>Empty list of shapes!</h1>";
            Formas = "shapes";
            Perimetro = "Perimeter";
            Total = "TOTAL:<br/>";
            Circle = "circle";
            Triangle = "triangle";
            Square = "square";
            Trapeze = "trapeze";
            Rectangle = "rectangle";
        }
    }
}
