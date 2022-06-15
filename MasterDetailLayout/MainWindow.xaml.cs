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

namespace MasterDetailLayout
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MovieRepository movieRepository;

        public MainWindow()
        {
            InitializeComponent();
            movieRepository = new();
            GridList.ItemsSource = movieRepository.GetAll();
        }
        private void ButtonClick_Search(object sender, RoutedEventArgs e)
        {
            List<Movie> movies = movieRepository.GetAll();
            List<Movie> matches = movies.Where(m => m.Title == Search_Bar.Text).ToList();
            GridList.ItemsSource = null;
            GridList.ItemsSource = movieRepository.GetAll();
        }
    }
}
