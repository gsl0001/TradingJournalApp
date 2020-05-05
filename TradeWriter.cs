using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingJpurnal
{
    public partial class TradeWriter : Form
    {
        Timer t = new Timer();
        public TradeWriter()
        {
            InitializeComponent();
        }
        

     

        private void button1_Click(object sender, EventArgs e)
        {

            this.Visible = false;
            Form1 form2 = new Form1();
            form2.Show();
        }

        private void TradeWriter_Load(object sender, EventArgs e)
        {
            t.Interval = 1000; // i.e. tick in milisecond
            t.Tick += new EventHandler(this.t_Tick);
            t.Start();


            day.Text = Methods.getDay();
        }
        void t_Tick(object sender, EventArgs e)
        {
            date.Text = Methods.getDate();

        }

        private void save_Click(object sender, EventArgs e)

        {
            DataManger.trades.Add(new Trade(time.Text, dd.Text, tk.Text, Convert.ToInt32(size.Text), Convert.ToDouble(et.Text), Convert.ToDouble(ex.Text), s.Text, p.Text, ls.Text, n.Text));
            DataManger.SaveData();
            this.l3.Text = "Saved Successfully !";
        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }

        private void et_TextChanged(object sender, EventArgs e)
        {
            te.Text = Calc.exposureCalc( Convert.ToDouble(et.Text), Convert.ToInt32(size.Text))+"";
        }

        private void ex_TextChanged(object sender, EventArgs e)
        {
           ae.Text = Calc.exposureCalc(Convert.ToDouble(ex.Text), Convert.ToInt32(size.Text)) + "";
           tpl.Text = Calc.plCalc(Convert.ToInt32(size.Text), Convert.ToDouble(et.Text), Convert.ToDouble(ex.Text), ls.Text)+"";
           plp.Text = Calc.gainPercenCalc(Convert.ToDouble(et.Text), Convert.ToDouble(ex.Text), ls.Text) + "";
            psg.Text = Calc.perSharePlCalc(Convert.ToDouble(et.Text), Convert.ToDouble(ex.Text), ls.Text) + "";

        }
    }
}
