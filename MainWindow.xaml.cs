using Elena.Kringe5DataSetTableAdapters;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Elena.Classes;
using Elena.AdminView; 
using Elena.SkladView;
using Elena.Kassir;

namespace Elena
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private authDataTableAdapter authData = new authDataTableAdapter();
        private postTableAdapter post = new postTableAdapter();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void complete_Click(object sender, RoutedEventArgs e)
        {
            var user = authData.GetData()
                .FirstOrDefault(element => element.login == login.Text && element.password == password.Password);


            if (user == null)
            {
                login.Text = null;
                password.Password = null;
                MessageBox.Show(Error.wrongLoginOrPassword);
                return;
            }

            string post = this.post.GetData()
                .First(element => element.ID == user.idPost).title;

            switch (post)
            {
                case "admin":
                    MainAdminWindow adminWindow = new MainAdminWindow();
                    adminWindow.Show();
                    this.Close();
                    break;
                case "kassir":
                    KassirMainWindow kassir = new KassirMainWindow(user);
                    kassir.Show();
                    this.Close();
                    break;
                case "sklad":
                    SkladMainWindow skladMain = new SkladMainWindow();
                    skladMain.Show();
                    this.Close();
                    break;
                default:
                    MessageBox.Show(Error.postError);
                    break;
            }
        }
    }
}
