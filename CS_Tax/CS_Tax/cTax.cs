using CS_Tax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSTax
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
    class cTax
        {
            public double item1;
            public double mcTaxRate = 0.85;

            public double GetAmount()
            {
                return item1;
            }

            public Double cFindTax (double cAmount)
            {
                return cAmount - (cAmount * mcTaxRate);
            }
        }
}
