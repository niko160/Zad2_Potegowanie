using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potegowanie
{
    class Rezultat
    {
        public Rezultat(long wynik, TimeSpan czasWykonania)
        {
            this.Wynik = wynik;
            this.CzasWykonania = czasWykonania;
        }

        public long Wynik { get; set; }
        public TimeSpan CzasWykonania { get; set; }

    }
}
