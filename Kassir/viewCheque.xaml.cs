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
    /// Логика взаимодействия для viewCheque.xaml
    /// </summary>
    public partial class viewCheque : Page
    {
        private chequeTableAdapter allCheque = new chequeTableAdapter();
        private userDataTableAdapter userData = new userDataTableAdapter();
        private productsTableAdapter products = new productsTableAdapter();
        private cheque_productsTableAdapter cheque_Products = new cheque_productsTableAdapter();

        private DataRowView cheque;

        public viewCheque()
        {
            InitializeComponent();
            allChequeComboBox.ItemsSource = allCheque.GetData();
            allChequeComboBox.DisplayMemberPath = "dateBuy";
        }

        private void allChequeComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            uploadCheque.IsEnabled = true;

            cheque = (allChequeComboBox.SelectedItem as DataRowView);

            var data = userData.GetData().First(element => element.ID == (int)cheque.Row[4]);

            userDataTextBlock.Text = $"{data.firstName} {data.lastName} {data.midleName}";
            dateTextBlock.Text = cheque.Row[3].ToString();
            priceTextBlock.Text = cheque.Row[1].ToString();

            chequeDataGrid.ItemsSource = convertProduct();
        }

        private void uploadCheque_Click(object sender, RoutedEventArgs e)
        {
            createFileCheque createFileCheque = new createFileCheque((int)cheque.Row[0]);
        }

        private List<productModel> convertProduct()
        {
            List<productModel> list = new List<productModel>();
            foreach(var element in cheque_Products.GetData())
            {
                foreach(var elem in products.GetData())
                {
                    if (element.idProducts == elem.ID)
                    {
                        list.Add(new productModel
                        {
                            ID = elem.ID,
                            title = elem.title,
                            idTypeProducts = elem.idTypeProducts,
                            price = elem.price,
                            count = element.count
                        });
                    }
                }
            }
            return list;
        }
    }
}
