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

namespace WpfApplication1
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double w = double.Parse(a.Text);
            double t = double.Parse(a.Text);
            double f = w / (t * t) / 10000;

        }

        private void ac_Click(object sender, RoutedEventArgs e)
        {
            
        }

        private void bc_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
