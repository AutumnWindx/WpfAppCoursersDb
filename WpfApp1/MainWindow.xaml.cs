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

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LoadData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Country().Show();
            this.Close();
        }

        private void LoadData()
        {
            GradesCB.ItemsSource = Helper.db.Wines.Where(y => y.Id >= 1).ToList();
            NameCB.ItemsSource = Helper.db.Wines.Where(x => x.Id >= 1).ToList();
        }

        private void SearcherClick(object sender, RoutedEventArgs e)
        {
            var wine = Helper.db.Wines.FirstOrDefault(q => q.TitleWine == SearchBox.Text);

            if (wine != null)
            {
                Helper.db.Wines.FirstOrDefault(t => t.Manufacturer == wine.Id);
                new SearchWine().Show();
                this.Close();
            }
            else
            {
                MessageBox.Show("Винное изделие не найдено");
            }
        }
    }
}
