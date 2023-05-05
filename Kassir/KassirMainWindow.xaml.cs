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
using Elena.Kringe5DataSetTableAdapters;

namespace Elena.Kassir
{
    /// <summary>
    /// Логика взаимодействия для KassirMainWindow.xaml
    /// </summary>
    public partial class KassirMainWindow : Window
    {
        private userDataTableAdapter userDataTable = new userDataTableAdapter();
        private Kringe5DataSet.authDataRow user;
        public KassirMainWindow(Kringe5DataSet.authDataRow user)
        {
            InitializeComponent();
            typeOfGet_Click(null, null);
            this.user = user;
        }

        private void typeOfGet_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new typeOfGet();
        }

        private void typeOfPay_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new typeOfPay();
        }

        private void createCheque_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new createCheque(userDataTable.GetData().First(element=>element.ID == user.idUserData));
        }

        private void vieCheque_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new viewCheque();
        }

        private void exit_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }

        private void typeOfCheque_Click(object sender, RoutedEventArgs e)
        {
            Frame.Content = new typeOfCheque();
        }
    }
}
