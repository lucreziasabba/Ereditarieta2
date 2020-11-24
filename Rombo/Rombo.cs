using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiGeometria
{
    public class Rombo : Quadrilatero
    {
        public double lato { get; }

        public Rombo(double l)
        {
            lato = l;
        }
    }
}
