using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatumCas04
{
    class Class1
    {
        public static int PocetDnu(DateTime prodano, int pocetLetZaruky)
        {

            int zbyva;
            DateTime dt = DateTime.Now;
           
                int rokKoupe = int.Parse(prodano.ToString());
                int datum = int.Parse(dt.ToString());
                zbyva = datum - rokKoupe;

            return zbyva;

        }
    }
}
