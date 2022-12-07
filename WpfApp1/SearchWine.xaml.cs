using Microsoft.EntityFrameworkCore;
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

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для SearchWine.xaml
    /// </summary>
    public partial class SearchWine : Window
    {
        public SearchWine()
        {
            InitializeComponent();

            LoadData();
        }
        private void LoadData()
        {
            Wines.ItemsSource = Helper.db.Wines.ToList();//
        }
    }
}
