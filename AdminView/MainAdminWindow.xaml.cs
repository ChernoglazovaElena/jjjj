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

namespace Elena.AdminView
{
    /// <summary>
    /// Логика взаимодействия для MainAdminWindow.xaml
    /// </summary>
    public partial class MainAdminWindow : Window
    {
        public MainAdminWindow()
        {
            InitializeComponent();
            post_Click(null, null);
        }

        private void post_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new postAdmin();
        }

        private void userData_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new userData();
        }

        private void authData_Click(object sender, RoutedEventArgs e)
        {
            frame.Content = new authData();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
