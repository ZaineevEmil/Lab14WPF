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

namespace Lab14WPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public List<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new List<Product>();
            products.Add(new Product()
            {
                ProductName = "Хлеб",
                ProductPrice = 50,
                ProductImage = "Data/braed.jpg",
                ProductType = ProductTypes.Eat
            });
            products.Add(new Product()
            {
                ProductName = "Сыр",
                ProductPrice = 500,
                ProductImage = "Data/cheese.jpg",
                ProductType = ProductTypes.Eat
            });
            products.Add(new Product()
            {
                ProductName = "Чайник",
                ProductPrice = 5000,
                ProductImage = "Data/teapot.jpg",
                ProductType = ProductTypes.Device
            });
            products.Add(new Product()
            {
                ProductName = "Холодильник",
                ProductPrice = 50000,
                ProductImage = "Data/refrigerator.jpg",
                ProductType = ProductTypes.Device
            });
            lstBox.ItemsSource = products;
        }
    }
}
