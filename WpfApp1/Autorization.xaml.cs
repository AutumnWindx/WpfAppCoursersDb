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
    /// Логика взаимодействия для Autorization.xaml
    /// </summary>
    public partial class Autorization : Window
    {
        public Autorization()
        {
            InitializeComponent();
        }

        private void LogInBtn_Click(object sender, RoutedEventArgs e)
        {
            if (LoginTBox.Text == "" || PasswordPBox.Password == "")
            {
                MessageBox.Show("Введите логин и пароль");
            }
            else
            {
                User user = Helper.db.Users.FirstOrDefault(q => q.Login == LoginTBox.Text && q.Password == PasswordPBox.Password);
                if (user != null)
                {
                    Helper.userSession = user;
                    Helper.db.SaveChanges();
                    new MainWindow().Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Неправильный логин или пароль");
                }
            }
        }

        private void RegBtn_Click(object sender, RoutedEventArgs e)
        {
            new Registration().Show();
            this.Close();
        }
    }
}
