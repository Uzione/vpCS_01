using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _018_RGBscroll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            this.BackColor = Color.LightSteelBlue;
            panel1.BackColor = Color.FromArgb(0,0,0);

            tRed.Text = "0";
            tGre.Text = "0";
            tBlu.Text = "0";

            scR.Maximum = 255 + 9;
            scG.Maximum = 255 + 9;
            scB.Maximum = 255 + 9;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void scr_Scroll(object sender, ScrollEventArgs e)
        {
            tRed.Text = scR.Value.ToString();
            tGre.Text = scG.Value.ToString();
            tBlu.Text = scB.Value.ToString();
            panel1.BackColor = Color.FromArgb(scR.Value, scG.Value, scB.Value);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (tRed.Text == "-" || tGre.Text == "-" || tBlu.Text == "-")
                return;
            if (tRed.Text != "" && tGre.Text != "" && tBlu.Text != "")
            {


                if (int.Parse(tRed.Text) > 255) tRed.Text = "255";
                if (int.Parse(tGre.Text) > 255) tGre.Text = "255";
                if (int.Parse(tBlu.Text) > 255) tBlu.Text = "255";


                if (int.Parse(tRed.Text) < 0) tRed.Text = "0";
                if (int.Parse(tGre.Text) < 0) tGre.Text = "0";
                if (int.Parse(tBlu.Text) < 0) tBlu.Text = "0";

                scR.Value = int.Parse(tRed.Text);
                scG.Value = int.Parse(tGre.Text);
                scB.Value = int.Parse(tBlu.Text);
                panel1.BackColor = Color.FromArgb(scR.Value, scG.Value, scB.Value);
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
