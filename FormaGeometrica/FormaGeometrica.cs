using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassiGeometria
{
    public class FormaGeometrica
    {
        internal int Tipo { get; }
         
        public FormaGeometrica(int t)
        {
            Tipo = t;
        }

        public void CalcolaPerimetro()
        {
            if (Tipo == 1)
            {
                double CalcolcaPerimetroRettangolo(Rettangolo rettangolo)
                {
                    double p = Quadrilatero.NumLatiQuadrilatero * rettangolo.lato;
                    return p;
                }
            }
            if (Tipo == 2)
            {
                double CalcolcaPerimetroRombo(Rombo rombo)
                {
                    double p = Quadrilatero.NumLatiQuadrilatero * rombo.lato;
                    return p;
                }
            }
        }
    }
}
