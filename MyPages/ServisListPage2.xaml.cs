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

namespace ПримерДляДЭ.MyPages
{
    /// <summary>
    /// Логика взаимодействия для ServisListPage2.xaml
    /// </summary>
    public partial class ServisListPage2 : Page
    {
        public ServisListPage2()
        {
            InitializeComponent();
            var serv = MyClass.ConnectObd.conOdb.Service.ToList();
            ListProduct.ItemsSource = serv;
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
