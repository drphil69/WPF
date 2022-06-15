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

namespace RedYellowGreen
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

        private void Green_Checked(object sender, RoutedEventArgs e)
        {
            StackPanel.Background = Brushes.Green;
        }
        private void Yellow_Checked(object sender, RoutedEventArgs e)
        {
            StackPanel.Background = Brushes.Yellow;
        }
        private void Red_Checked(object sender, RoutedEventArgs e)
        {
            StackPanel.Background = Brushes.Red;
        }
    }
}
