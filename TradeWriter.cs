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
           
            //test.Text = string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", time.Text, dd.Text, tk.Text, int.Parse(s.Text.ToString()), double.Parse(et.Text.ToString()), double.Parse(ex.Text.ToString()), s.Text, p.Text, ls.Text, n.Text);
            //Console.Write(string.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9}", time.Text, dd.Text, tk.Text, int.Parse(s.Text), double.Parse(et.Text), double.Parse(ex.Text), s.Text, p.Text, ls.Text, n.Text));
             DataManger.trades.Add(new Trade(time.Text, dd.Text, tk.Text, int.Parse(s.Text+""), double.Parse(et.Text+""), double.Parse(ex.Text+""), s.Text, p.Text, ls.Text, n.Text));
        }

        private void time_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
