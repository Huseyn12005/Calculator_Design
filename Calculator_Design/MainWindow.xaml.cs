using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace Calculator_Design
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
        char emel = ' ';
        double num;

        private void yeddi_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "";
            }

            tb.Text += "7";
        }

        private void sekkiz_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "";
            }

            tb.Text += "8";
        }

        private void doqquz_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "";
            }

            tb.Text += "9";
        }

        private void bol_Click(object sender, RoutedEventArgs e)
        {
            if (emel == ' ')
            {
                emel = '/';
                num = Convert.ToDouble(tb.Text);
                tb.Text = "0";
            }
        }

        private void vur_Click(object sender, RoutedEventArgs e)
        {
            if (emel == ' ')
            {
                emel = '*';
                num = Convert.ToDouble(tb.Text);
                tb.Text = "0";
            }
        }

        private void dord_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "";
            }

            tb.Text += "4";
        }

        private void bes_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "";
            }

            tb.Text += "5";
        }

        private void alti_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "";
            }

            tb.Text += "6";
        }

        private void cix_Click(object sender, RoutedEventArgs e)
        {
            if (emel == ' ')
            {
                emel = '-';
                num = Convert.ToDouble(tb.Text);
                tb.Text = "0";
            }
        }

        private void bir_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "";
            }

            tb.Text += "1";
        }

        private void iki_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "";
            }

            tb.Text += "2";
        }

        private void uc_Click(object sender, RoutedEventArgs e)
        {
            if (tb.Text == "0")
            {
                tb.Text = "";
            }

            tb.Text += "3";
        }

        private void plus_Click(object sender, RoutedEventArgs e)
        {
            if (emel == ' ')
            {
                emel = '+';
                num = Convert.ToDouble(tb.Text);
                tb.Text = "0";
            }
        }

        private void sifir_Click(object sender, RoutedEventArgs e)
        {
            if ((!(tb.Text == "0")) || tb.Text.Contains(".0"))
            {
                tb.Text += '0';
            }
        }

        private void noqte_Click(object sender, RoutedEventArgs e)
        {
            if (!tb.Text.Contains('.'))
                tb.Text += ".";
        }

        private void beraber_Click(object sender, RoutedEventArgs e)
        {
            if (emel == '+')
            {
                tb.Text = Convert.ToString(Convert.ToDouble(tb.Text) + num);
            }

            else if (emel == '-')
            {
                tb.Text = Convert.ToString(Convert.ToDouble(tb.Text) - num);
            }

            else if (emel == '*')
            {
                tb.Text = Convert.ToString(Convert.ToDouble(tb.Text) * num);
            }

            else if (emel == '/')
            {
                tb.Text = Convert.ToString(num / Convert.ToDouble(tb.Text));
            }
            emel = ' ';
        }

        private void x2_Click(object sender, RoutedEventArgs e)
        {
         
            tb.Text = Convert.ToString(Math.Pow(Convert.ToDouble(tb.Text),2));
        }

        private void kok_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = Convert.ToString(Math.Sqrt(Convert.ToDouble(tb.Text)));
        }


        private void CE_Click(object sender, RoutedEventArgs e)
        {
            tb.Text = "0";
            emel = ' ';
        }
    }

}
