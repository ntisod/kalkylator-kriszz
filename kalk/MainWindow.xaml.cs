using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
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

namespace kalk
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

        private void Btn_1_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "1";
            else boxix.Text += "1";
        }

        private void Boxix_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Btn_2_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "2";
            else boxix.Text += "2";
        }

        private void Btn_3_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "3";
            else boxix.Text += "3";
        }

        private void Btn_4_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "4";
            else boxix.Text += "4";
        }

        private void Btn_5_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "5";
            else boxix.Text += "5";
        }

        private void Btn_6_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "6";
            else boxix.Text += "6";
        }

        private void Btn_7_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "7";
            else boxix.Text += "7";
        }

        private void Btn_8_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "8";
            else boxix.Text += "8";
        }

        private void Btn_9_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "9";
            else boxix.Text += "9";
        }

        private void Btn_min_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "-";
            else boxix.Text += "-";
        }

        private void Btn_0_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "0";
            else boxix.Text += "0";
        }

        private void Btn_plus_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "+";
            else boxix.Text += "+";
        }

        private void Btn_c_Click(object sender, RoutedEventArgs e)
        {
            boxix.Text = "0";
        }

        private void Btn_lika_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DataTable dt = new DataTable();
                var v = dt.Compute(boxix.Text, "");
                boxix.Text = v.ToString();
            }
            catch
            {
                boxix.Text = "Noob KYS";
            }
        }

        private void Btn_dela_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "/";
            else boxix.Text += "/";
        }

        private void Btn_times_Click(object sender, RoutedEventArgs e)
        {
            if (boxix.Text == "0")
                boxix.Text = "*";
            else boxix.Text += "*";
        }
    }
}
