using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingJpurnal
{
    class Trade
    {
        private string time { get; set; }
        private string day { get; set; }

        private string ticker { get; set; }
        private int size { get; set; }
        private double entry { get; set; }
        private double exit { get; set; }
        private string stratagey { get; set; }
        private string fplan { get; set; }
        private string dirc { get; set; }
        private string note { get; set; }

        private double pl { get; set; }//profit loss
        private double gainPerShare { get; set; }// gain and loss per share
        private double glp { get; set; } //gain loss percent 

        private double grossExp { get; set; }
        private double grossReturn { get; set; }

        public Trade(string time, string day, string ticker, int size, double entry, double exit, string stat, string p, string dirc,string note)
        {
            this.time = time;
            this.day = day;
            this.ticker = ticker;
            this.size = size;
            this.entry = entry;
            this.exit = exit;
            this.stratagey = stat;
            this.fplan = p;
            this.dirc = dirc;
            this.note = note;

            this.pl = Calc.plCalc(size, entry, exit, dirc);
            this.glp = Calc.gainPercenCalc(entry, exit, dirc);
            this.gainPerShare = Calc.perSharePlCalc(entry, exit, dirc);

            this.grossExp = Calc.exposureCalc(entry, size);
            this.grossReturn = Calc.afterTradeAmtCalc(exit, size);


        }
        public Trade(string time, string day, string ticker, int size, double entry, double exit, string stat, string p, string dirc, string note,double pl,double glp, double gainPerShare, double grossExp, double grossReturn)
        {
            this.time = time;
            this.day = day;
            this.ticker = ticker;
            this.size = size;
            this.entry = entry;
            this.exit = exit;
            this.stratagey = stat;
            this.fplan = p;
            this.dirc = dirc;
            this.note = note;

            this.pl = pl;
            this.glp = glp;
            this.gainPerShare = gainPerShare;

            this.grossExp = grossExp;
            this.grossReturn = grossReturn;


        }

        private string ToString( )
        {
            return string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13},{14}" , 
                this.time,this.day, this.ticker, this.size, this.entry, this.exit, this.stratagey, this.fplan, this.dirc, this.note, this.pl,this.glp, this.gainPerShare, this.grossExp, this.grossReturn);


        }
    }
}
