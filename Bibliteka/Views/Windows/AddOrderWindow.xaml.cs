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
    /// Логика взаимодействия для AddOrderWindow.xaml
    /// </summary>
    public partial class AddOrderWindow : Window
    {
        private BiblitekaEntities _context = App.GetContext();
        public AddOrderWindow()
        {
            InitializeComponent();
            GuestComboBox.ItemsSource = _context.Guest.ToList();
            DishComboBox.ItemsSource = _context.Dish.ToList();
            StatusComboBox.ItemsSource = _context.DishStatus.ToList();
        }
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            var guest = GuestComboBox.SelectedItem as Guest;
            var dish = DishComboBox.SelectedItem as Dish;
            var status = StatusComboBox.SelectedItem as DishStatus;

            if (guest == null || dish == null)
            {
                MessageBox.Show("Выберите гостя и блюдо.");
                return;
            }

            var guestDish = new GuestDish
            {
                GuestId = guest.Id,
                DishId = dish.Id,
                DishStatusId = status?.Id
            };

            _context.GuestDish.Add(guestDish);
            _context.SaveChanges();

            MessageBox.Show("Заказ добавлен.");
            this.DialogResult = true;
            this.Close();
        }
}
}
