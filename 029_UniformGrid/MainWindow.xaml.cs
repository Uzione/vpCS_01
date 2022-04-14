using System;
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

namespace _029_UniformGrid
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            ChessBoard.Rows = 8;
            ChessBoard.Columns = 8;

            for(int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (i % 2 == 0 && j % 2 == 0)
                    {
                        Rectangle r = new Rectangle();
                        r.Fill = Brushes.Black;
                        ChessBoard.Children.Add(r);
                    }
                    else if (i % 2 == 1 && j % 2 == 0)
                    {
                        Rectangle r = new Rectangle();
                        r.Fill = Brushes.Red;
                        ChessBoard.Children.Add(r);
                    }
                    else if (i % 2 == 0 && j % 2 == 1)
                    {
                        Rectangle r = new Rectangle();
                        r.Fill = Brushes.Red;
                        ChessBoard.Children.Add(r);
                    }
                    else if (i % 2 == 1 && j % 2 == 1)
                    {
                        Rectangle r = new Rectangle();
                        r.Fill = Brushes.Black;
                        ChessBoard.Children.Add(r);
                    }
                }
            }
        }
    }
}
