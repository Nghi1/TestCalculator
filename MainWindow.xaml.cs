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

namespace _151901403_VuThanhNghi
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            float a, b, kq;
            a = float.Parse(txt1.Text);
            b = float.Parse(txt2.Text);
            Calculator c = new Calculator(a, b);
            kq = c.Exectute("+");
            txt3.Text = kq.ToString();
        }

        private void txt3_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void but2_Click(object sender, RoutedEventArgs e)
        {

            float a, b, kq;
            a = float.Parse(txt1.Text);
            b = float.Parse(txt2.Text);
            Calculator c = new Calculator(a, b);
            kq = c.Exectute("-");
            txt3.Text = kq.ToString();
        }

        private void but3_Click(object sender, RoutedEventArgs e)
        {

            float a, b, kq;
            a = float.Parse(txt1.Text);
            b = float.Parse(txt2.Text);
            Calculator c = new Calculator(a, b);
            kq = c.Exectute("*");
            txt3.Text = kq.ToString();
        }

        private void but4_Click(object sender, RoutedEventArgs e)
        {
            float a, b, kq;
            a = float.Parse(txt1.Text);
            b = float.Parse(txt2.Text);
            Calculator c = new Calculator(a, b);
            kq = c.Exectute("/");
            txt3.Text = kq.ToString();
        }

        private void but5_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
