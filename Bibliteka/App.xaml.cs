using Bibliteka.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Bibliteka
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        private static BiblitekaEntities _context;
        public static BiblitekaEntities GetContext()
        {
            if (_context == null)
            {
                _context = new BiblitekaEntities();
            }
            return _context;
        }
    }
}
