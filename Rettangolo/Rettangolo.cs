using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiGeometria
{
    public class Rettangolo : Quadrilatero
    {
        public double lato { get; }

        public Rettangolo(double l)
        {
            lato = l;
        }
    }
}
