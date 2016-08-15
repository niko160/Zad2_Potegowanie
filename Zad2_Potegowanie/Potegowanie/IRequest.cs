using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potegowanie
{
    internal interface IRequest
    {
        long podstawa { get; set; }
        long wykladnik { get; set; }
        long POW();
    }
}
