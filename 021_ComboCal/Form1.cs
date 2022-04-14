using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _021_ComboCal
{
    public partial class Form1 : Form
    {
        TextBox[] titles;
        ComboBox[] crds;
        ComboBox[] grds;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBox1.Text = "인체의구조와기능I";
            textBox2.Text = "데이터사이언스";
            textBox3.Text = "설계및프로젝트기본I";
            textBox4.Text = "기업가정신";
            textBox5.Text = "비주얼프로그래밍";
            textBox6.Text = "일반수학I";
            textBox7.Text = "전자공학및실험";

            //titles = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5, textBox6, textBox7 };
            crds = new ComboBox[] { cbCrd1, cbCrd2, cbCrd3, cbCrd4, cbCrd5, cbCrd6, cbCrd7 };
            grds = new ComboBox[] { cbGrd1, cbGrd2, cbGrd3, cbGrd4, cbGrd5, cbGrd6, cbGrd7 };

            int[] arrCrd = { 1, 2, 3, 4, 5 };
            List<string> listGrd = new List<string>()
            {
                "A+","A0","B+","B0","C+","C0","D+","D0","F"
            };

            foreach (var c in crds)
                foreach (var i in arrCrd)
                {
                    c.Items.Add(i);
                    c.SelectedItem = 3;
                }
            foreach (var g in grds)
                foreach (var c in listGrd)
                {
                    g.Items.Add(c);
                }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double totalScore = 0;
            int totalCredit = 0;

            for(int i = 0; i < grds.Length; i++)
            {
                if(grds[i].SelectedItem != null)
                {
                    int crd = int.Parse(crds[i].SelectedItem.ToString());
                    totalCredit += crd;
                    totalScore += crd * GetGrade(grds[i].SelectedItem.ToString());
                }
            }
            txAvr.Text = (totalScore/totalCredit).ToString("0.00");
        }

        private double GetGrade(string v)
        {
            double grade = 0;

            if (v == "A+") grade = 4.5;
            if (v == "A0") grade = 4.0;
            if (v == "B+") grade = 3.5;
            if (v == "B0") grade = 3.0;
            if (v == "C+") grade = 2.5;
            if (v == "C0") grade = 2.0;
            if (v == "D+") grade = 1.5;
            if (v == "D0") grade = 1.0;
            if (v == "F") grade = 0;
            
            return grade;
        }
    }
}