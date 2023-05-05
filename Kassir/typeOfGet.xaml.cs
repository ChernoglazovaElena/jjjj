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
    /// Логика взаимодействия для typeOfGet.xaml
    /// </summary>
    public partial class typeOfGet : Page
    {
        private typeToGetTableAdapter typeOfGetAdapter = new typeToGetTableAdapter();

        public typeOfGet()
        {
            InitializeComponent();
            clearAll();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(title.Text))
            {
                MessageBox.Show(Error.emptyString);
                return;
            }
            else if (typeOfGetDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            else if(isExist(title.Text, (int)(typeOfGetDataGrid.SelectedItem as DataRowView).Row[0]))
            {
                MessageBox.Show(Error.isExist);
                return;
            }
            typeOfGetAdapter.UpdateQuery(title.Text, (int)(typeOfGetDataGrid.SelectedItem as DataRowView).Row[0]);
            clearAll();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (typeOfGetDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            typeOfGetAdapter.DeleteQuery((int)(typeOfGetDataGrid.SelectedItem as DataRowView).Row[0]);
            clearAll();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(title.Text))
            {
                MessageBox.Show(Error.emptyString);
                return;
            }
            else if (isExist(title.Text))
            {
                MessageBox.Show(Error.isExist);
                return;
            }
            typeOfGetAdapter.InsertQuery(title.Text);
            clearAll();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                title.Text = (typeOfGetDataGrid.SelectedItem as DataRowView).Row[1].ToString();
            }
            catch { };
        }
        private void clearAll()
        {
            title.Text = null;
            typeOfGetDataGrid.ItemsSource = typeOfGetAdapter.GetData();
        }
        private bool isExist(string data, int ID = -1)
        {
            if (typeOfGetAdapter.GetData()
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
