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
using System.Windows.Threading;

namespace CatchMeGame
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        #region Fields
        private int pointsCount;
        #endregion

        #region Constructors
        public MainWindow()
        {
            InitializeComponent();
        } 
        #endregion

        #region Methods
        private void CatchMe_Clicked(object sender, RoutedEventArgs e)
        {
            pointsCount = pointsCount += 1;
            Points.Text = "Dine Point:\n       " + pointsCount.ToString();
            moveButton();
            if (pointsCount <= 20)
            {
                moveButton();
            }
        }
        private void moveButton()
        {
            Random rnd = new Random();
            int randomMarginTop = rnd.Next(0, 1400);
            int randomMarginRight = rnd.Next(0, 750);
            CatchMe_Button.Margin = new(randomMarginTop, randomMarginRight, 0, 0);
        }
        #endregion
    }
}
