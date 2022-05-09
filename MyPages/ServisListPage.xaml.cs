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
    /// Interaction logic for ServisListPage.xaml
    /// </summary>
    public partial class ServisListPage : Page
    {
        public ServisListPage()
        {
            InitializeComponent();
            var serv =MyClass.ConnectObd.conOdb.Service.ToList();
            ListProduct.ItemsSource = serv;

        }

        private void TxtSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
            var screatString = TxtSearch.Text;
            ListProduct.ItemsSource = MyClass.ConnectObd.conOdb.Service.Where(u => u.Title.StartsWith(screatString)).ToList();
        }

        private void btnEdit_Click(object sender, RoutedEventArgs e)
        {
            MyClass.FrameObj.framMain.Navigate(new PageEditNew((sender as Button).DataContext as Service));
        }

        private void btnSalvHistory_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
