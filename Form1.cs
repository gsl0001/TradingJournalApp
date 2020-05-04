using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TradingJpurnal
{
    public partial class Form1 : Form
    {
        
        Dictionary<string, int> stats = new Dictionary<string, int>();
        Timer t = new Timer();
       

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
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
        private void button4_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage2;
            button3.BackColor = Color.Black;
            button4.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            tabControl1.SelectedTab = tabPage1;
            button4.BackColor = Color.Black;
            button3.BackColor = Color.FromArgb(26, 26, 26);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            TradeWriter form2 = new TradeWriter();
            form2.Show();
        }

        private void date_Click(object sender, EventArgs e)
        {

        }

        private void day_Click(object sender, EventArgs e)
        {

        }
    }
}
