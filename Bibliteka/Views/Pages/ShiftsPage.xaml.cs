﻿using Bibliteka.Model;
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
    /// Логика взаимодействия для ShiftsPage.xaml
    /// </summary>
    public partial class ShiftsPage : Page
    {
        private static BiblitekaEntities _context = App.GetContext();
        public ShiftsPage()
        {
            InitializeComponent();
            ShiftsLb.ItemsSource = _context.Shift.ToList();
        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
