using System;
using System.Collections.Generic;

using Timer = System.Windows.Forms.Timer;

namespace TradingJpurnal
{
    class Methods
    {
        public static string getDate()
        {
            return  DateTime.Now+"";

        }

    public static string getDay()
        {
            return "Day: "+ DateTime.Now.ToString("ddd");
        }
    }
}
