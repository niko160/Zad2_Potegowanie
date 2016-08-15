using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Potegowanie
{
    class POW_Check
    {
        Stack<IRequest> undoStack = new Stack<IRequest>();
        public Rezultat WykonajMetode(IRequest request)
        {
            undoStack.Push(request);
            var stanPoczatkowy = System.DateTime.Now;
            var wynik = request.POW();
            var stanKoncowy = System.DateTime.Now;
            var czasWykonania = stanKoncowy.Subtract(stanPoczatkowy);
            return new Rezultat(wynik, czasWykonania);
        }

        public IRequest PobierzOstatnia()
        {
            if (undoStack.Count() >= 1)
            {
                return undoStack.Pop();
            }

            return null;
        }
    }
}
