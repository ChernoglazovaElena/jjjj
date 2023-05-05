using System;
using System.Collections.Generic;
using System.Data;
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
using Elena.Classes;
using Elena.Kringe5DataSetTableAdapters;

namespace Elena.Kassir
{
    /// <summary>
    /// Логика взаимодействия для typeOfPay.xaml
    /// </summary>
    public partial class typeOfPay : Page
    {
        private typeOfPayTableAdapter typeOfPayAdapter = new typeOfPayTableAdapter();

        public typeOfPay()
        {
            InitializeComponent();
            clearAll();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(title.Text))
            {
                MessageBox.Show(Error.emptyString);
                return;
            }
            else if (isExist(title.Text))
            {
                MessageBox.Show(Error.isExist);
                return;
            }
            typeOfPayAdapter.InsertQuery(title.Text);
            clearAll();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (typeOfPayDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            typeOfPayAdapter.DeleteQuery((int)(typeOfPayDataGrid.SelectedItem as DataRowView).Row[0]);
            clearAll();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(title.Text))
            {
                MessageBox.Show(Error.emptyString);
                return;
            }
            else if (typeOfPayDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            else if (isExist(title.Text, (int)(typeOfPayDataGrid.SelectedItem as DataRowView).Row[0]))
            {
                MessageBox.Show(Error.isExist);
                return;
            }
            typeOfPayAdapter.UpdateQuery(title.Text,(int)(typeOfPayDataGrid.SelectedItem as DataRowView).Row[0]);
            clearAll();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                title.Text = (typeOfPayDataGrid.SelectedItem as DataRowView).Row[1].ToString();
            }
            catch
            {
                clearAll();
            }
        }

        private void clearAll()
        {
            title.Text = null;
            typeOfPayDataGrid.ItemsSource = typeOfPayAdapter.GetData();
        }

        private bool isExist(string data, int ID = -1)
        {
            if (typeOfPayAdapter.GetData()
                .FirstOrDefault(element => element.title.ToLower() == data.ToLower() && element.ID != ID) != null)
                return true;
            return false;
        }

        private void price_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
