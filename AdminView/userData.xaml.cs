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

namespace Elena.AdminView
{
    /// <summary>
    /// Логика взаимодействия для userData.xaml
    /// </summary>
    public partial class userData : Page
    {
        private userDataTableAdapter userDataTable = new userDataTableAdapter();
        public userData()
        {
            InitializeComponent();
            clearTextBox();
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (userDataDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            else if (string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(secondName.Text) || string.IsNullOrWhiteSpace(midleName.Text))
            {
                MessageBox.Show(Error.emptyString);
                return;
            }
            userDataTable.UpdateQuery(name.Text, secondName.Text, midleName.Text, (int)(userDataDataGrid.SelectedItem as DataRowView).Row[0]);
            clearTextBox();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (userDataDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            userDataTable.DeleteQuery((int)(userDataDataGrid.SelectedItem as DataRowView).Row[0]);
            clearTextBox();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(name.Text) || string.IsNullOrWhiteSpace(secondName.Text) || string.IsNullOrWhiteSpace(midleName.Text))
            {
                MessageBox.Show(Error.emptyString);
                return;
            }
            userDataTable.InsertQuery(name.Text, secondName.Text, midleName.Text);
            clearTextBox();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var selectedItem = (userDataDataGrid.SelectedItem as DataRowView);
                name.Text = selectedItem.Row[1].ToString();
                secondName.Text = selectedItem.Row[2].ToString();
                midleName.Text = selectedItem.Row[3].ToString();
            }
            catch
            {
                userDataDataGrid.SelectedIndex = -1;
            };
        }
        private void clearTextBox()
        {
            name.Text = null;
            secondName.Text = null;
            midleName.Text = null;
            userDataDataGrid.ItemsSource = userDataTable.GetData();
        }

        private void textBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (char.IsDigit(e.Text, 0)) e.Handled = true;
        }
    }
}
