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
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Xml.Linq;
using Elena.Classes;
using Elena.Kringe5DataSetTableAdapters;
using MaterialDesignThemes.Wpf;

namespace Elena.Kassir
{
    public partial class createCheque : Page
    {
        private productsTableAdapter products = new productsTableAdapter();
        private typeToGetTableAdapter typeToGet = new typeToGetTableAdapter();
        private typeOfPayTableAdapter typeOfPay = new typeOfPayTableAdapter();
        private typeOfChequeTableAdapter typeOfCheque = new typeOfChequeTableAdapter();
        private chequeTableAdapter cheque = new chequeTableAdapter();
        private cheque_productsTableAdapter cheque_Products = new cheque_productsTableAdapter();

        private List<productModel> _allProducts = new List<productModel>();
        private List<productModel> _cardList = new List<productModel>();

        private Kringe5DataSet.userDataRow user;
        int allPrice = 0;

        public createCheque(Kringe5DataSet.userDataRow user)
        {
            InitializeComponent();

            convertToProductModelList();

            typeGet.DisplayMemberPath = "title";
            typePay.DisplayMemberPath = "title";
            typeCheque.DisplayMemberPath = "title";

            typeGet.ItemsSource = typeToGet.GetData();
            typePay.ItemsSource = typeOfPay.GetData();
            typeCheque.ItemsSource = typeOfCheque.GetData();

            this.user = user;

            updateDataGrid();
        }

        private void price_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if (!char.IsDigit(e.Text, 0)) e.Handled = true;
        }

        private void allProducts_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var element = (allProducts.SelectedItem as productModel);

                if (allProducts.SelectedIndex > -1 && element != null)
                {
                    if (element.title == null) return;

                    element.count--;


                    if (element.count == 0)
                    {
                        _allProducts.Remove(element);
                    }

                    var cardElement = _cardList.FirstOrDefault(elem => elem.ID == element.ID);

                    if (cardElement == null)
                    {
                        var newProduct = element.Clone();
                        (newProduct as productModel).count = 1;
                        _cardList.Add((newProduct as productModel));
                    }
                    else
                    {
                        foreach (var elem in _cardList)
                        {
                            if (elem.ID == element.ID)
                            {
                                elem.count++;
                                break;
                            }
                        }
                    }
                    changePrice();
                    updateDataGrid();
                }
            }
            catch
            {
                _cardList.Remove(_cardList.Last()) ;
            }
        }

        private void card_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            try
            {
                var element = (card.SelectedItem as productModel);

                if (card.SelectedItem != null && element != null)
                {
                    if (element.title == null) return;

                    element.count--;

                    if (element.count == 0)
                    {
                        _cardList.Remove(element);
                    }

                    var cardElement = _allProducts.FirstOrDefault(elem => elem.ID == element.ID);

                    if (cardElement == null)
                    {
                        var newProduct = element.Clone();
                        (newProduct as productModel).count = 1;
                        _allProducts.Add((newProduct as productModel));
                    }
                    else
                    {
                        foreach (var elem in _allProducts)
                        {
                            if (elem.ID == element.ID)
                            {
                                elem.count++;
                                break;
                            }
                        }
                    }

                    changePrice();
                    updateDataGrid();
                }
            }
            catch { };
        }

        private void convertToProductModelList()
        {
            foreach (var element in products.GetData())
            {
                if(element.cout != 0)
                {
                    _allProducts.Add(new productModel
                    {
                        ID = element.ID,
                        title = element.title,
                        idTypeProducts = element.idTypeProducts,
                        price = element.price,
                        count = element.cout
                    });
                }
            } 
        }

        private void updateDataGrid()
        {
            allProducts.ItemsSource = null;
            card.ItemsSource = null;

            allProducts.ItemsSource = _allProducts;
            card.ItemsSource = _cardList;
        }

        private void pay_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(typeGet.Text) || string.IsNullOrWhiteSpace(typePay.Text) || string.IsNullOrWhiteSpace(price.Text) || string.IsNullOrWhiteSpace(typeCheque.Text) || _cardList.Count == 0)
            {
                MessageBox.Show(Error.emptyString);
                return;
            }
            else if(Convert.ToInt32(price.Text) < allPrice)
            {
                MessageBox.Show(Error.insufficientFunds);
                return;
            }

            cheque.Insert(allPrice, Convert.ToInt32(price.Text) - allPrice, DateTime.Now, user.ID, (int)(typeGet.SelectedItem as DataRowView).Row[0], (int)(typePay.SelectedItem as DataRowView).Row[0],(int)(typeCheque.SelectedItem as DataRowView).Row[0]);
            clearAll();
        }

        private void changePrice()
        {
            allPrice = 0;
            foreach (var element in _cardList)
            {
                allPrice += element.price;
            }
            cardPrice.Text = $"Цена: {allPrice}";
        }

        private void clearAll()
        {
            createFileCheque createCheque = new createFileCheque(cheque.GetData().Last().ID);

            cardPrice.Text = null;
            typeGet.Text = null;
            price.Text = null;

            addProducts();
            updateProductsInfo();

            _allProducts.Clear();
            _cardList.Clear();

            convertToProductModelList();
            updateDataGrid();
            changePrice();

        }

        private void updateProductsInfo()
        {
            foreach(var element in products.GetData())
            {
                foreach(var elem in _cardList)
                {
                    if(element.ID == elem.ID)
                    {
                        products.UpdateCount(Math.Abs(element.cout - elem.count), element.ID);
                    }
                }
            }
        }

        private void addProducts()
        {
            foreach(var element in _cardList)
            {
                cheque_Products.InsertQuery(cheque.GetData().Last().ID, element.ID, element.count);
            }
        }
    }
}