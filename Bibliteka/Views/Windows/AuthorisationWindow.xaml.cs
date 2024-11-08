using Bibliteka.AppData;
using Bibliteka.Views.AdminViews;
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
    /// Логика взаимодействия для AuthorisationWindow.xaml
    /// </summary>
    public partial class AuthorisationWindow : Window
    {
        public AuthorisationWindow()
        {
            InitializeComponent();
        }

        private void LoginTb_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdatePlaceholders();
        }

        private void PassTb_PasswordChanged(object sender, RoutedEventArgs e)
        {
            UpdatePlaceholders();
        }

        private void UpdatePlaceholders()
        {
            LoginPlaceholder.Visibility = string.IsNullOrEmpty(LoginTb.Text) ? Visibility.Visible : Visibility.Collapsed;
            PasswordPlaceholder.Visibility = string.IsNullOrEmpty(PassTb.Password) ? Visibility.Visible : Visibility.Collapsed;
        }

        private void EntryBtn_Click(object sender, RoutedEventArgs e)
        {
            if (AuthorisationHelper.Authorise(LoginTb.Text, PassTb.Password))
            {
                switch (AuthorisationHelper.selectedUser.RoleId)
                {
                    case 1:
                        break;
                    case 2:
                        break;
                    case 3:
                        break;
                    case 4:
                        AdminWIndow adminWIndow = new AdminWIndow();
                        adminWIndow.Show();
                        Close();
                        break;
                    default:
                        MessageBoxHelper.Error("Ошибка выбора роли.");
                        break;
                }
            }
        }
    }
}
