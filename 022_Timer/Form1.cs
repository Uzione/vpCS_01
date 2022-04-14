using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _022_Timer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbTime.Font = new Font("맑은 고딕", 20, FontStyle.Bold);
            lbTime.Text = "";
            timer1.Interval = 1000;
            timer1.Tick += Timer1_Tick;
            timer1.Start();
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            lbTime.Text = DateTime.Now.ToString();
            lbTime.Location = new Point(
                ClientSize.Width / 2 - lbTime.Width / 2, ClientSize.Height / 2 - lbTime.Height / 2);
        }

        private void lbTime_Click(object sender, EventArgs e)
        {

        }
    }
}
