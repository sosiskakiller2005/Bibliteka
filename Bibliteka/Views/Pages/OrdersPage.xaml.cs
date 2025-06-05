using Bibliteka.Model;
using Bibliteka.Views.Windows;
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

namespace Bibliteka.Views.Pages
{
    /// <summary>
    /// Логика взаимодействия для OrdersPage.xaml
    /// </summary>
    public partial class OrdersPage : Page
    {
        private static BiblitekaEntities _context = App.GetContext();
        public OrdersPage()
        {
            InitializeComponent();
            OrdersDg.ItemsSource = _context.GuestDish.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddOrderWindow addOrderWindow = new AddOrderWindow();
            if (addOrderWindow.ShowDialog() == true)
            {
                OrdersDg.ItemsSource = App.GetContext().GuestDish.ToList();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
