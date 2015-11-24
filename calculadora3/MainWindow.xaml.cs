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

namespace calculadora
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

        private void btnsoma_Click(object sender, RoutedEventArgs e)
        {
            int valor1, valor2, total;

            valor1 = Convert.ToInt16(vlr1.Text);
            valor2 = Convert.ToInt16(vlr2.Text);

            total = valor1 + valor2;

            result.Text = total.ToString();


        }

        private void btnsub_Click(object sender, RoutedEventArgs e)
        {
            int valor1, valor2, total;

            valor1 = Convert.ToInt16(vlr1.Text);
            valor2 = Convert.ToInt16(vlr2.Text);

            total = valor1 - valor2;

            result.Text = total.ToString();

        }

        private void btnmult_Click(object sender, RoutedEventArgs e)
        {
            Double valor1, valor2, total;

            valor1 = Convert.ToDouble(vlr1.Text);
            valor2 = Convert.ToDouble(vlr2.Text);

            total = valor1 * valor2;

            result.Text = total.ToString();

        }

        private void btndiv_Click(object sender, RoutedEventArgs e)
        {
            Double valor1, valor2, total;

            valor1 = Convert.ToDouble(vlr1.Text);
            valor2 = Convert.ToDouble(vlr2.Text);

            total = valor1 / valor2;

            result.Text = total.ToString();

        }

        private void btnlimp_Click(object sender, RoutedEventArgs e)
        {

            vlr1.Clear();
            vlr2.Clear();
            result.Clear();

        }


    }
}





