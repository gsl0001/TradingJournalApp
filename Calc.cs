using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace TradingJpurnal
{
    class Calc
    {
        //total profit loss
        public static double  plCalc(int size, double entry, double exit, string dirc)
        {
            return  dirc == "long" ? (exit - entry)*size : (entry - exit)*size;
        }
        //loss gain per share
        public static double perSharePlCalc( double entry, double exit, string dirc)
        {
            return  dirc == "long" ? (exit - entry) : (entry - exit);
        }

        // profit loss percentage
        public static double gainPercenCalc( double entry, double exit, string dirc)
        {
            return dirc == "long" ? (exit - entry)/exit *100 : (entry - exit)/entry*100;
        }

        // total exposure
        public static double exposureCalc( double entry, int size)
        {
            return entry * size;
        }

        // total after trade amount
        public static double afterTradeAmtCalc(double exit, int size)
        {
            return exit * size;
        }










    }
}
