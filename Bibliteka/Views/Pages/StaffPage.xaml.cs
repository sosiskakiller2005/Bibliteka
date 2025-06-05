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
    /// Логика взаимодействия для StaffPage.xaml
    /// </summary>
    public partial class StaffPage : Page
    {
        private static BiblitekaEntities _context = App.GetContext();
        public StaffPage()
        {
            InitializeComponent();
            StaffGv.ItemsSource = _context.Staff.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditStaffWindow addEditStaffWindow = new AddEditStaffWindow();
            if (addEditStaffWindow.ShowDialog() == true)
            {
                StaffGv.ItemsSource = App.GetContext().Staff.ToList();
            }
        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {
            AddEditStaffWindow addEditStaffWindow = new AddEditStaffWindow(StaffGv.SelectedItem as Staff);
            if (addEditStaffWindow.ShowDialog() == true)
            {
                StaffGv.ItemsSource = App.GetContext().Staff.ToList();
            }
        }
    }
}
