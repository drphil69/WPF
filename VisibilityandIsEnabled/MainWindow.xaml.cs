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

namespace VisibilityandIsEnabled
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

        private void Red_Checked(object sender, RoutedEventArgs e)
        {
            StackPanel.Background = Brushes.Red;
        }
        private void Yellow_Checked(object sender, RoutedEventArgs e)
        {
            StackPanel.Background = Brushes.Yellow;
        }
        private void Green_Checked(object sender, RoutedEventArgs e)
        {
            StackPanel.Background = Brushes.Green;
        }
        private void Hidden_Checked(object sender, RoutedEventArgs e)
        {
            Red.Visibility = Visibility.Hidden;
            Yellow.Visibility = Visibility.Hidden;
            Green.Visibility = Visibility.Hidden;
        }
        private void Enabled_Checked(object sender, RoutedEventArgs e)
        {
            Red.IsEnabled = true;
            Yellow.IsEnabled = true;
            Green.IsEnabled = true;
            Red.Visibility = Visibility.Visible;
            Yellow.Visibility = Visibility.Visible;
            Green.Visibility = Visibility.Visible;
        }
        private void Disabled_Checked(object sender, RoutedEventArgs e)
        {
            Red.IsEnabled = false;
            Yellow.IsEnabled = false;
            Green.IsEnabled = false;
            Red.Visibility = Visibility.Visible;
            Yellow.Visibility = Visibility.Visible;
            Green.Visibility = Visibility.Visible;
        }
    }
}
