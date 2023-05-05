using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
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
    /// Логика взаимодействия для product.xaml
    /// </summary>
    public partial class product : Page
    {
        private productsTableAdapter products = new productsTableAdapter();
        private typeProductsTableAdapter typeProduts = new typeProductsTableAdapter();

        public product()
        {
            InitializeComponent();
            clearAll();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(title.Text) || string.IsNullOrWhiteSpace(typeProductsComboBox.Text) || string.IsNullOrWhiteSpace(price.Text) || string.IsNullOrWhiteSpace(count.Text))
            {
                MessageBox.Show(Error.emptyString);
                return;
            } 
            else if (isExist(title.Text))
            {
                MessageBox.Show(Error.isExist);
                return;
            }
            products.InsertQuery(title.Text, (int)(typeProductsComboBox.SelectedItem as DataRowView).Row[0],Convert.ToInt32(price.Text), Convert.ToInt32(count.Text));
            clearAll();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if(productsDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            products.DeleteQuery((int)(productsDataGrid.SelectedItem as DataRowView).Row[0]) ;
            clearAll();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (productsDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            else if (string.IsNullOrWhiteSpace(title.Text) || string.IsNullOrWhiteSpace(typeProductsComboBox.Text) || string.IsNullOrWhiteSpace(price.Text) || string.IsNullOrWhiteSpace(count.Text))
            {
                MessageBox.Show(Error.emptyString);
                return;
            }
            else if (isExist(title.Text, (int)(productsDataGrid.SelectedItem as DataRowView).Row[0]))
            {
                MessageBox.Show(Error.isExist);
                return;
            }
            products.UpdateQuery(title.Text, (int)(typeProductsComboBox.SelectedItem as DataRowView).Row[0],Convert.ToInt32(price.Text), Convert.ToInt32(count.Text), (int)(productsDataGrid.SelectedItem as DataRowView).Row[0]);
            clearAll();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                title.Text = (productsDataGrid.SelectedItem as DataRowView).Row[1].ToString();
                price.Text = (productsDataGrid.SelectedItem as DataRowView).Row[3].ToString();
                count.Text = (productsDataGrid.SelectedItem as DataRowView).Row[4].ToString();
                typeProductsComboBox.Text = typeProduts.GetData().First(element => element.ID == (int)(productsDataGrid.SelectedItem as DataRowView).Row[2]).title;
            }
            catch
            {
                productsDataGrid.SelectedIndex = -1;
            }
        }
        private void clearAll()
        {
            title.Text = null;
            typeProductsComboBox.Text = null;
            price.Text = null;
            count.Text = null;
            productsDataGrid.ItemsSource = products.GetData();
            typeProductsComboBox.ItemsSource = typeProduts.GetData();
            typeProductsComboBox.DisplayMemberPath = "title";
        }

        private bool isExist(string data, int ID = -1)
        {
            if (typeProduts.GetData()
                .FirstOrDefault(element => element.title.ToLower() == data.ToLower() && element.ID != ID) != null)
                return true;
            return false;
        }
        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, 0)) e.Handled = true;
        }
        private void textBox2_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (char.IsLetter(e.Text, 0)) e.Handled = true;
        }
    }
}
