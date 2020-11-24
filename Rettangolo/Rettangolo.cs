using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiGeometria
{
    public class Rettangolo : Quadrilatero
    {
        public double Base { get; set; }
        public double alt { get; set; }

        public Rettangolo(int nl, double b, double h) : base(NumLatiQuadrilatero)
        {
            Base = b;
            alt = h;
        }
        public string CalcolaPerimetro()
        {
            double perimetro = (Base + alt) * 2;
            return ("Il perimetro è perimetro"+ perimetro);
        }

        public string CalcolaArea()
        {
            double area = Base * alt;
            return ("L'area è "+area);
        }
    }
}
