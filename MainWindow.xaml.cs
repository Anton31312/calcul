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

namespace fed1isp11_17
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnSum_Click(object sender, RoutedEventArgs e)
        {
            int num1, num2, sum;
            num1 = Convert.ToInt32(tbNum1.Text);
            num2 = Convert.ToInt32(tbNum2.Text);
            sum = num1 + num2;
            tbResult.Text = sum.ToString();
        }

        private void btnSub_Click(object sender, RoutedEventArgs e)
        {
            int num3, num4, sub;
            num3 = Convert.ToInt32(tbNum3.Text);
            num4 = Convert.ToInt32(tbNum4.Text);
            sub = num3 - num4;
            tbSub.Text = sub.ToString();
        }

        private void btnMult_Click(object sender, RoutedEventArgs e)
        {
            int num5, num6, mult;
            num5 = Convert.ToInt32(tbNum5.Text);
            num6 = Convert.ToInt32(tbNum6.Text);
            mult = num5 * num6;
            tbMult.Text = mult.ToString();

        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            int num7, num8, div;
            num7 = Convert.ToInt32(tbNum7.Text);
            num8 = Convert.ToInt32(tbNum8.Text);
            div = num7 / num8;
            tbDiv.Text = div.ToString();
        }
    }
}
