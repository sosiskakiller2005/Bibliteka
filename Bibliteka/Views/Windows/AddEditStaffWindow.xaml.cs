using Bibliteka.Model;
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

namespace Bibliteka.Views.Windows
{
    /// <summary>
    /// Логика взаимодействия для AddEditStaffWindow.xaml
    /// </summary>
    public partial class AddEditStaffWindow : Window
    {
        private BiblitekaEntities _context = App.GetContext();
        public AddEditStaffWindow()
        {
            InitializeComponent();
            SaveBtn.Visibility = Visibility.Collapsed; 
            RoleCmb.ItemsSource = _context.Role.ToList();
            RoleCmb.DisplayMemberPath = "Name";

        }
        public AddEditStaffWindow(Staff selectedStaff)
        {
            InitializeComponent();
            AddBtn.Visibility = Visibility.Collapsed;
            RoleCmb.ItemsSource = _context.Role.ToList();
            RoleCmb.DisplayMemberPath = "Name";
            DataContext = selectedStaff;
        }

        private void SaveBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var staff = DataContext as Staff;
                if (staff != null)
                {
                    _context.SaveChanges();
                    MessageBox.Show("Сотрудник успешно изменен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при изменении сотрудника.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                var newStaff = new Staff
                {
                    Name = NameTb.Text,
                    Age = int.Parse(AgeTb.Text),
                    PhoneNumber = PhoneTb.Text,
                    RoleId = (RoleCmb.SelectedItem as Role)?.Id ?? 0,
                    Login = LoginTb.Text,
                    Password = PassPb.Password,
                    StatusId = 1
                };

                if (newStaff != null)
                {
                    _context.Staff.Add(newStaff);
                    _context.SaveChanges();
                    MessageBox.Show("Сотрудник успешно добавлен!", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                    Close();
                }
                else
                {
                    MessageBox.Show("Ошибка при добавлении сотрудника.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
