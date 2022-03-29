using System.Windows;
using System.Windows.Controls;
using Services;

namespace WSRDemo
{
    public partial class LoginPage : Page
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void LoginButton_OnClick(object sender, RoutedEventArgs e)
        {
            var loginStatus = AuthService.Login(LoginTextBox.Text.Trim(), PasswordTextBox.Text.Trim());

            MessageBox.Show(loginStatus ? "Вход выполнен" : "Неверный логин или пароль");
        }
    }
}