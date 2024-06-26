using Microsoft.SqlServer.Server;
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

namespace _8._1
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            string password = txtPassword2.Password;

            if (IsPasswordValid(password))
            {
                MessageBox.Show("Пароль действителен. Войдите в систему...");
            }
            else
            {
                MessageBox.Show("Пароль не соответствует предъявляемым требованиям. Пожалуйста, попробуйте снова.");
            }
        }

        private bool IsPasswordValid(string password)
        {
            // Проверка длины пароля
            if (password.Length < 8)
                return false;

            // Проверка наличия цифры
            if (!ContainsDigit(password))
                return false;

            // Проверка наличия верхнего регистра
            if (!ContainsUppercase(password))
                return false;

            // Проверка наличия нижнего регистра
            if (!ContainsLowercase(password))
                return false;

            return true;
        }

        private bool ContainsDigit(string password)
        {
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                    return true;
            }
            return false;
        }

        private bool ContainsUppercase(string password)
        {
            foreach (char c in password)
            {
                if (char.IsUpper(c))
                    return true;
            }
            return false;
        }

        private bool ContainsLowercase(string password)
        {
            foreach (char c in password)
            {
                if (char.IsLower(c))
                    return true;
            }
            return false;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window8 f = new Window8();
            f.ShowDialog();
        }
    }
}
