﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _025_WPFhello
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtHello_MouseDown(object sender, MouseButtonEventArgs e)
        {
            MessageBox.Show("TextBlock Cliked");

            if (Grid1.Background == Brushes.IndianRed)
                Grid1.Background = Brushes.Orange;
            else
                Grid1.Background = Brushes.IndianRed;
        }
    }
}