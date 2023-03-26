using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace Wpf14
{
    public partial class MainWindow : Window
    {
        public ObservableCollection<Product> products;
        public MainWindow()
        {
            InitializeComponent();
            products = new ObservableCollection<Product>();
            products.Add(new Product()
            {
                ProdName="Гантели",
                ProdPrise = 3590,
                ProdImage ="Date/gantely.jpg",
                ProductCategory = ProductCategorys.SportsEquipment
            });
            products.Add(new Product()
            {
                ProdName = "Эспандер",
                ProdPrise = 480,
                ProdImage = "Date/espander.jpg",
                ProductCategory = ProductCategorys.SportsEquipment
            });
            products.Add(new Product()
            {
                ProdName = "Коврик для йоги",
                ProdPrise = 1290,
                ProdImage = "Date/cover.jpg",
                ProductCategory = ProductCategorys.SportsEquipment
            });
            products.Add(new Product()
            {
                ProdName = "Спортивная куртка",
                ProdPrise = 18370,
                ProdImage = "Date/jacket.jpg",
                ProductCategory = ProductCategorys.SportWearShoes
            });
            products.Add(new Product()
            {
                ProdName = "Кроссовки",
                ProdPrise = 7490,
                ProdImage = "Date/krossovki.jpg",
                ProductCategory = ProductCategorys.SportWearShoes
            });
            products.Add(new Product()
            {
                ProdName = "Футболка",
                ProdPrise = 3210,
                ProdImage = "Date/t-shirt.jpg",
                ProductCategory = ProductCategorys.SportWearShoes
            });
            listBox.ItemsSource = products;          
        }
    }
} 
