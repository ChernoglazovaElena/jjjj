using System;
using System.Collections.Generic;
using System.IO.Packaging;
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
using System.Runtime.CompilerServices;
using System.Data;
using Elena.Kringe5DataSetTableAdapters;

namespace Elena.AdminView
{
    /// <summary>
    /// Логика взаимодействия для postAdmin.xaml
    /// </summary>
    public partial class postAdmin : Page
    {
        postTableAdapter post = new postTableAdapter();
        public postAdmin()
        {
            InitializeComponent();
            postDataGrid.ItemsSource = post.GetData();
        }

        private void save_Click(object sender, RoutedEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(title.Text))
            {
                if (isExist(title.Text))
                {
                    MessageBox.Show(Error.isExist);
                    return;
                }
                post.InsertQuery(title.Text);
                clearField();
            }
            else
            {
                MessageBox.Show(Error.emptyString);
            }
        }
        private void delete_Click(object sender, RoutedEventArgs e)
        {
            if (postDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            post.DeleteQuery((int)(postDataGrid.SelectedItem as DataRowView).Row[0]);
            clearField();
        }
        private void update_Click(object sender, RoutedEventArgs e)
        {
            if (postDataGrid.SelectedIndex <= -1)
            {
                MessageBox.Show(Error.notSelected);
                return;
            }
            else if (string.IsNullOrWhiteSpace(title.Text))
            {
                MessageBox.Show(Error.emptyString);
                return;
            }
            else if (isExist(title.Text))
            {
                MessageBox.Show(Error.isExist);
                return;
            }
            post.UpdateQuery(title.Text, (int)(postDataGrid.SelectedItem as DataRowView).Row[0]);
            clearField();
        }

        private void DataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                title.Text = (postDataGrid.SelectedItem as DataRowView).Row[1].ToString();
            }
            catch
            {
                postDataGrid.SelectedIndex = -1;
            };
        }

        private void clearField()
        {
            title.Text = null;
            postDataGrid.ItemsSource = post.GetData();
        }
        private bool isExist(string data)
        {
            if(post.GetData()
                .FirstOrDefault(element => element.title.ToLower() == data.ToLower()) != null)
                    return true;
            return false;
        }
    }
}