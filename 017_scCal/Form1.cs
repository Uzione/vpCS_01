using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _017_scCal
{
    public partial class 성적계산기 : Form
    {
        public 성적계산기()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(tKor.Text) +
            Convert.ToDouble(tMat.Text) + Convert.ToDouble(tEng.Text);

            double ave = sum / 3;

            tSum.Text = sum.ToString();
            tAve.Text = ave.ToString("0.0");
        }

        private void 성적계산기_Load(object sender, EventArgs e)
        {

        }
    }
}
