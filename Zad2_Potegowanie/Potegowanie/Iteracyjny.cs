using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potegowanie
{
    public class Iteracyjny : IRequest
    {
        public long podstawa { get; set; }
        public long wykladnik { get; set; }

        public long POW()
        {
            long wynik = 1;
            for (var i = 0; i < this.wykladnik; i++)
            {
                wynik *= this.podstawa;
            }

            return wynik;
        }
    }
}
