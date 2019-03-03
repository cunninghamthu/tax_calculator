using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSTax
{
    class cTax
    {
        public double item1;
        public double mcTaxRate = 0.85;

        public double GetAmount()
        {
            return item1;
        }

        public Double cFindTax(double cAmount)
        {
            return cAmount - (cAmount * mcTaxRate);
        }
    }
}
