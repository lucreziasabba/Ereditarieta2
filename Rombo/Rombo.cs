using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiGeometria
{
    public class Rombo : Quadrilatero
    {
        public double lato { get; set; }
        public double Dmax { get; set; }
        public double Dmin { get; set; }

        public Rombo(int nl, double l, double dmin, double dmax) : base(NumLatiQuadrilatero)
        {
            lato = l;
            Dmax = dmax;
            Dmin = dmin;
        }
        public string CalcolaPerimetro()
        {
            double perimetro = lato * NumLatiQuadrilatero;
            return ("Il perimetro è perimetro" + perimetro);
        }

        public string CalcolaArea()
        {
            double area = Dmax * Dmax / 2;
            return ("L'area è " + area);
        }
    }
}
