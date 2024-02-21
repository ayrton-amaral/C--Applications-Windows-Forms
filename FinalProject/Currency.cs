using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject
{
    internal class Currency
    {
        public double CanadianFactor { get; }

        public string CurrencyName { get; } 
        
        public Currency(double canadianFactor, string currencyName)
        {
            CanadianFactor = canadianFactor;
            CurrencyName = currencyName;
        }

        public double ConvertToCAD(double valueInserted)
        {
            return valueInserted * CanadianFactor;
        }

        public double FromCADtoCurrency(double cadValue)
        {
            return cadValue / CanadianFactor;
        }
    }
}
