using IOL.CodingChallenge.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOL.CodingChallenge.Modelo
{
   public class Italiano : Idioma
    {
        public Italiano()
        {
            Titulo = "<h1>Rapporto sulle forme</h1>";
            ListaVacia = "<h1>Elenco vuoto di forme!</h1>";
            Formas = "forme";
            Perimetro = "Perimetro";
            Total = "TOTAL:<br/>";
        }
    }
}
