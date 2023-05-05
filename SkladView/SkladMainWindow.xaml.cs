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

namespace Elena.SkladView
{
    /// <summary>
    /// Логика взаимодействия для SkladMainWindow.xaml
    /// </summary>
    public partial class SkladMainWindow : Window
    {
        public SkladMainWindow()
        {
            InitializeComponent();
            typeOfProducts_Click(null,null);
        }

        private void typeOfProducts_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new typeProducts();
        }

        private void products_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new product();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
