using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiGeometria
{
    public class Triangolo
    {
        internal const int NumLatiTriangolo = 3;
        public double Base { get; set; }
        public double Altezza { get; set; }
        public double Lato2 { get; set; }
        public double Lato3 { get; set; }

        public string CalcolaPerimetro()
        {
            double perimetro = Base + Lato2+Lato3;
            return ("Il perimetro è perimetro" + perimetro);
        }

        public string CalcolaArea()
        {
            double area = (Base * Altezza)/2;
            return ("L'area è " + area);
        }
    }
}
