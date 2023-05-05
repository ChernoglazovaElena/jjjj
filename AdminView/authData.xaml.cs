using Elena.Kringe5DataSetTableAdapters;
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
using System.Xml.Linq;
using Elena.Classes;

namespace Elena.AdminView
{
    /// <summary>
    /// Логика взаимодействия для authData.xaml
    /// </summary>
    public partial class authData : Page
    {
        private authDataTableAdapter authdata = new authDataTableAdapter();
        private userDataTableAdapter userData = new userDataTableAdapter();
        private postTableAdapter postTable = new postTableAdapter();
        public authData()
        {
            InitializeComponent();

            postComboBox.ItemsSource = postTable.GetData();

            postComboBox.DisplayMemberPath = "title";
            userDataComboBox.DisplayMemberPath = "lastName";

            clearAll();
            userDataComboBox.Text = "asdasdasd";
        }

        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (authDataDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            else if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(password.Password) || string.IsNullOrEmpty(postComboBox.Text) || string.IsNullOrWhiteSpace(userDataComboBox.Text))
            {
                MessageBox.Show(Error.emptyString);
                return;
            }
            else if (isExist(login.Text))
            {
                MessageBox.Show(Error.isExist);
                return;
            }
            authdata.UpdateQuery(login.Text, password.Password, (int)(postComboBox.SelectedItem as DataRowView).Row[0], (userDataComboBox.SelectedItem as Kringe5DataSet.userDataRow).ID, (int)(authDataDataGrid.SelectedItem as DataRowView).Row[0]);
            clearAll();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(login.Text) || string.IsNullOrEmpty(password.Password) || string.IsNullOrEmpty(postComboBox.Text) || string.IsNullOrWhiteSpace(userDataComboBox.Text))
            {
                MessageBox.Show(Error.emptyString);
                return;
            }
            else if (isExist(login.Text))
            {
                MessageBox.Show(Error.isExist);
                return;
            }
            authdata.InsertQuery(login.Text, password.Password, (int)(postComboBox.SelectedItem as DataRowView).Row[0], (userDataComboBox.SelectedItem as Kringe5DataSet.userDataRow).ID);
            clearAll();
        }

        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if(authDataDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            authdata.DeleteQuery((int)(authDataDataGrid.SelectedItem as DataRowView).Row[0]);
            clearAll();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                login.Text = (authDataDataGrid.SelectedItem as DataRowView).Row[1].ToString();
                password.Password = (authDataDataGrid.SelectedItem as DataRowView).Row[2].ToString();
                userDataComboBox.Text = userData.GetData().First(element=>element.ID == (int)(authDataDataGrid.SelectedItem as DataRowView).Row[4]).lastName;
                postComboBox.Text = postTable.GetData().First(element=>element.ID == (int)(authDataDataGrid.SelectedItem as DataRowView).Row[3]).title;
            }
            catch
            {
                authDataDataGrid.SelectedIndex = -1;
            };
        }
        private void clearAll()
        {
            login.Text = null;
            password.Password = null;
            postComboBox.Text = null;
            userDataComboBox.Text = null;
            authDataDataGrid.ItemsSource = authdata.GetData();
            userDataComboBox.ItemsSource = userData.GetData().Where(element => (int)authdata.ScalarQuery(element.ID) == 0);
        }
        private bool isExist(string data)
        {
            if (authdata.GetData()
                .FirstOrDefault(element => element.login == data) != null)
                return true;
            return false;
        }
    }
}
