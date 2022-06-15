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

namespace ItemsControls
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>

    public partial class MainWindow : Window
    {
        private List<Product> dataSource = new()


        {
            new() { Id = 1, Name = "Redbull", CreationDate = new(1982, 05, 04), Description = "Redbull giver vingeeer", Category = "Drikkevarer", ProductExpired = false, UnitPrice = 20.95m, AvailableProducts = 24 },
            new() { Id = 2, Name = "River", CreationDate = new(1982, 05, 04), Description = "Let the river run", Category = "Drikkevarer", ProductExpired = false, UnitPrice = 20.95m, AvailableProducts = 24 },
            new() { Id = 3, Name = "Monster", CreationDate = new(1982, 05, 04), Description = "Monsters Inc", Category = "Drikkevarer", ProductExpired = false, UnitPrice = 20.95m, AvailableProducts = 24 },
            new() { Id = 13, Name = "Øreringe", CreationDate = new(1982, 05, 04), Description = "Ring om øre", Category = "Accessories", ProductExpired = false, UnitPrice = 20.95m, AvailableProducts = 24 },
            new() { Id = 14, Name = "Tåringe", CreationDate = new(1982, 05, 04), Description = "Ring om tå", Category = "Accessories", ProductExpired = false, UnitPrice = 20.95m, AvailableProducts = 24 },
            new() { Id = 15, Name = "Piercing", CreationDate = new(1982, 05, 04), Description = "ad", Category = "Accessories", ProductExpired = false, UnitPrice = 20.95m, AvailableProducts = 24 },
            new() { Id = 16, Name = "Ur", CreationDate = new(1982, 05, 04), Description = "Kig'e'klok", Category = "Accessories", ProductExpired = false, UnitPrice = 20.95m, AvailableProducts = 24 },
            new() { Id = 22, Name = "Asfalt", CreationDate = new(1982, 05, 04), Description = "I fortovet", Category = "Byggematerialer", ProductExpired = false, UnitPrice = 20.95m, AvailableProducts = 24 },
            new() { Id = 25, Name = "Lego", CreationDate = new(1982, 05, 04), Description = "Danske klodser", Category = "Byggematerialer", ProductExpired = false, UnitPrice = 20.95m, AvailableProducts = 24 },
            new() { Id = 29, Name = "Netherbricks", CreationDate = new(1982, 05, 04), Description = "Ja jeg har taget minecraft blocks med", Category = "Byggematerialer", ProductExpired = false, UnitPrice = 20.95m, AvailableProducts = 24 },
        };
        public MainWindow()
        {
            InitializeComponent();
            SortBy_Name();
        }
        private void SortBy_Name()
        {
            dataSource = dataSource.OrderBy(p => p.Name).ToList();
            listBoxProducts.ItemsSource = null;
            listBoxProducts.ItemsSource = dataSource;
            GridList.ItemsSource = null;
            GridList.ItemsSource = dataSource;
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (AddProduct_CreationDate.SelectedDate == null)
            {
                MessageBox.Show("Indsæt venligst en dato");
            }
            else
            {
                if (AddProduct_Category.SelectedItem == null)
                {
                    MessageBox.Show("Vælg venligst en kategori");
                }
                else
                {
                    Product p = new() { Id = 11, Name = AddProduct_Name.Text, CreationDate = AddProduct_CreationDate.SelectedDate.Value, Description = AddProduct_Description.Text, Category = AddProduct_Category.SelectedItem.ToString(), ProductExpired = false, UnitPrice = Convert.ToDecimal(AddProduct_UnitPrice.Text), AvailableProducts = Convert.ToInt32(AddProduct_AvailableProducts.Text) };
                    dataSource.Add(p);
                    SortBy_Name();
                }
            }
        }

        private void listBoxProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                Product selectedProduct = (Product)listBoxProducts.SelectedItem;
                AddProduct_Name.Text = selectedProduct.Name;
                AddProduct_CreationDate.SelectedDate = selectedProduct.CreationDate;
                AddProduct_Description.Text = selectedProduct.Description;
                AddProduct_UnitPrice.Text = Convert.ToString(selectedProduct.UnitPrice);
                AddProduct_AvailableProducts.Text = Convert.ToString(selectedProduct.AvailableProducts);
                AddProduct_Category.SelectedValue = selectedProduct.Category;
            }
        }
        private void Edit_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxProducts.SelectedItem != null)
            {
                Product selectedProduct = (Product)listBoxProducts.SelectedItem;
                selectedProduct.Name = AddProduct_Name.Text;
                selectedProduct.CreationDate = AddProduct_CreationDate.SelectedDate.Value;
                selectedProduct.Description = AddProduct_Description.Text;
                selectedProduct.UnitPrice = Convert.ToDecimal(AddProduct_UnitPrice.Text);
                selectedProduct.AvailableProducts = Convert.ToInt32(AddProduct_AvailableProducts.Text);
                selectedProduct.Category = (string)AddProduct_Category.SelectedValue;
                SortBy_Name();
                MessageBox.Show($"Du har nu redigeret {selectedProduct.Name}!");
            }
        }
    }
}