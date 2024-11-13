using Bibliteka.AppData;
using Bibliteka.Views.Pages;
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
using System.Windows.Shapes;

namespace Bibliteka.Views.AdminViews
{
    /// <summary>
    /// Логика взаимодействия для AdminWindow.xaml
    /// </summary>
    public partial class AdminWIndow : Window
    {
        public AdminWIndow()
        {
            InitializeComponent();
            FrameHelper.selectedFrame = MainFrm;
            MainFrm.Navigate(new OrdersPage());
        }

        private void OrdersBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new OrdersPage());
        }

        private void StaffBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new StaffPage());
        }

        private void ShiftsBtn_Click(object sender, RoutedEventArgs e)
        {
            MainFrm.Navigate(new ShiftsPage());
        }
    }
}
