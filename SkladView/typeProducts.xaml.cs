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
using Elena.AdminView;
using Elena.Classes;
using Elena.Kringe5DataSetTableAdapters;

namespace Elena.SkladView
{
    /// <summary>
    /// Логика взаимодействия для typeProducts.xaml
    /// </summary>
    public partial class typeProducts : Page
    {
        private typeProductsTableAdapter typeProduct = new typeProductsTableAdapter();
        public typeProducts()
        {
            InitializeComponent();
            clearAll();
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (typeProductsDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            else if(string.IsNullOrWhiteSpace(title.Text))
            {
                MessageBox.Show(Error.emptyString);
                return;
            }
            else if (isExist(title.Text))
            {
                MessageBox.Show(Error.isExist);
                return;
            }
            typeProduct.UpdateQuery(title.Text, (int)(typeProductsDataGrid.SelectedItem as DataRowView).Row[0]);
            clearAll();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if(typeProductsDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            typeProduct.DeleteQuery((int)(typeProductsDataGrid.SelectedItem as DataRowView).Row[0]);
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
            typeProduct.InsertQuery(title.Text);
            clearAll();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                title.Text = (typeProductsDataGrid.SelectedItem as DataRowView).Row[1].ToString();
            }
            catch
            {
                typeProductsDataGrid.SelectedIndex = -1;
            }
        }
        private bool isExist(string data)
        {
            if (typeProduct.GetData()
                .FirstOrDefault(element => element.title.ToLower() == data.ToLower()) != null)
                return true;
            return false;
        }
        private void clearAll()
        {
            title.Text = null;
            typeProductsDataGrid.ItemsSource = typeProduct.GetData();
        }
    }
}
