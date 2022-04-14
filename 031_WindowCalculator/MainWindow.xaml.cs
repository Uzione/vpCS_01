using System;
using System.Windows;
using System.Windows.Controls;

namespace _031_WindowCalculator
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool opFlag = false;
        bool memFalg = false;
        bool end = false;
        double saved;
        string op;

        public MainWindow()
        {
            InitializeComponent();
            btnMC.IsEnabled = false;
            btnMR.IsEnabled = false;
        }

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            string s = btn.Content.ToString();

            if (txtResult.Text == "0" || opFlag == true || memFalg == true || end == true)
            {
                txtResult.Text = s;
                txtExp.Text = "";

                opFlag = false;
                memFalg = false;
                end = false;
            }
            else txtResult.Text += s;

        }

        private void btnDot_Click(object sender, RoutedEventArgs e)
        {
            if (txtResult.Text.Contains(".")) return;
            else txtResult.Text += ".";
        }

        private void btn_OPclick(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            saved = double.Parse(txtResult.Text);
            txtExp.Text = txtResult.Text + btn.Content.ToString();
            op = btn.Content.ToString();
            opFlag = true;
        }

        private void btnEqual_Click(object sender, RoutedEventArgs e)
        {
            end = true;
            double v = double.Parse(txtResult.Text);
            txtExp.Text += txtResult.Text + "=";
            switch (op)
            {
                case "+":
                    txtResult.Text = (saved + v).ToString();
                    break;
                case "-":
                    txtResult.Text = (saved - v).ToString();
                    break;
                case "×":
                    txtResult.Text = (saved * v).ToString();
                    break;
                case "÷":
                    txtResult.Text = (saved / v).ToString();
                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
        }

        private void btnPlusMinus_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = (-1 * double.Parse(txtResult.Text)).ToString();
        }

        private void btnPer_Click(object sender, RoutedEventArgs e)
        {
            double p = double.Parse(txtResult.Text);
            p = saved * p / 100;
            txtResult.Text = p.ToString();
            //txtExp.Text += txtResult.Text;
        }

        private void btnSqrt_Click(object sender, RoutedEventArgs e)
        {
            if (txtExp.Text == "")
                txtExp.Text = "√(" + txtResult.Text + ")";
            else
                txtExp.Text = txtExp.Text = "√(" + txtExp.Text + ")";
            txtResult.Text = Math.Sqrt(double.Parse(txtResult.Text)).ToString();
        }

        private void btnSqr_Click(object sender, RoutedEventArgs e)
        {
            if (txtExp.Text == "")
                txtExp.Text = "sqr(" + txtResult.Text + ")";
            else
                txtExp.Text = txtExp.Text = "sqr(" + txtExp.Text + ")";
            double v = double.Parse(txtResult.Text);
            txtResult.Text = (v * v).ToString();
        }

        private void btnRecip_Click(object sender, RoutedEventArgs e)
        {
            if (txtExp.Text == "")
                txtExp.Text = "1/(" + txtResult.Text + ")";
            else
                txtExp.Text = txtExp.Text = "1/(" + txtExp.Text + ")";
            double v = double.Parse(txtResult.Text);
            txtResult.Text = (1 / v).ToString();
        }

        private void btnC_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = "0";
            txtExp.Text = "";
            saved = 0;
            op = "";
            opFlag = false;
        }

        private void btnDel_Click(object sender, RoutedEventArgs e)
        {
            txtResult.Text = txtResult.Text.Remove(txtResult.Text.Length - 1);
            if (txtResult.Text.Length == 0)
                txtResult.Text = "0";
        }
    }
}