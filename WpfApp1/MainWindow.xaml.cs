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
using System.Threading;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int en; //konečné číslo
        static int rt; //počet opakování čísla 
        static bool b;
        static CancellationTokenSource cancelSource = new CancellationTokenSource();
        CancellationToken ct = cancelSource.Token;
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = this;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            en = 1;
            b = true;
            while (b)
            {
                en++;
                Algorithm();
            }
        }

        public void Algorithm()
        {
            for (int i = 2; i < 10; i++)
            {
                if (en != i) if (en % i == 0) return; //kontroluje prvočíslo
            }
            string s = Convert.ToString(en);
            rt = Convert.ToInt16(rtimes1.Text);
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == Convert.ToChar(number1.Text))
                {
                    for (int ii = 0; ii < rt; ii++)
                    {
                        if (i + rt >= s.Length) return;
                        else if (s[i + ii] != Convert.ToChar(number1.Text)) return;

                    }
                    endnumber1.Content = en; //výpis finálního čísla
                    b = false;
                }
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

        }
    }
}
