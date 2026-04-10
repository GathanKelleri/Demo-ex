using System.Windows;
using KafedraApp.Data;

namespace KafedraApp
{
    public partial class LoginWindow : Window
    {
        private readonly DbReader _dbReader = new DbReader();

        public LoginWindow()
        {
            InitializeComponent();
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            ErrorTextBlock.Text = string.Empty;

            var login = LoginTextBox.Text.Trim();
            var password = PasswordBox.Password;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                ErrorTextBlock.Text = "Введите логин и пароль.";
                return;
            }

            if (!_dbReader.ValidateUser(login, password))
            {
                ErrorTextBlock.Text = "Неверный логин или пароль.";
                return;
            }

            var mainWindow = new MainWindow(_dbReader);
            mainWindow.Show();
            Close();
        }
    }
}
