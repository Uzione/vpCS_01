using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _020_CB
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = (ComboBox)sender;
            lbrestaurant.Text =
                "모임 장소 " + cb.SelectedItem.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text != "")
            {
                comboBox1.Items.Add(comboBox1.Text);
                lbrestaurant.Text = comboBox1.Text + " Adeed";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex >= 0)
            {
                lbrestaurant.Text = comboBox1.SelectedItem.ToString() + " Deleted";
                comboBox1.Items.Remove(comboBox1.SelectedItem);
            }
        }
    }
}
