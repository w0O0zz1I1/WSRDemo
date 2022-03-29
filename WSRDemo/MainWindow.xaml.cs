using System;
using System.Windows;
using System.Windows.Controls;

namespace WSRDemo
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            Loaded += MainWindow_Loaded;

            /* LoginTextBox.MouseEnter += RemoveText;
             LoginTextBox.MouseLeave += AddText;
 
             PasswordTextBox.MouseEnter += RemoveText;
             PasswordTextBox.MouseLeave += AddText;*/
        }

        /*    public string CurrentText { get; set; }
    
            public void RemoveText(object sender, EventArgs e)
            {
                TextBox instance = (TextBox)sender;
                CurrentText = instance.Text;
    
                if (instance.Text == CurrentText)
                    instance.Text = string.Empty;
            }
    
            public void AddText(object sender, EventArgs e)
            {
                TextBox instance = (TextBox)sender;
                if (string.IsNullOrWhiteSpace(instance.Text))
                    instance.Text = CurrentText;
    
            }*/
        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            var loginPage = MainFrame.Navigate(new LoginPage());
        }
    }
}