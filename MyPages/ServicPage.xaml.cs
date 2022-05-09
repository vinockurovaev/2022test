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
    /// Interaction logic for ServicPage.xaml
    /// </summary>
    public partial class ServicPage : Page
    {
        public ServicPage()
        {
            InitializeComponent();
            MyClass.ConnectObd.conOdb = new SalonEntities1();
            DGridServic.ItemsSource = MyClass.ConnectObd.conOdb.Service.ToList();
        }

        private void cbSort_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (cbSort.SelectedIndex == 0)
            {//сортировка по возрастанию
                DGridServic.ItemsSource = ((List<Service>)DGridServic.ItemsSource).OrderBy(u => u.Title).ToList();
            }
            else
            {
                //сортировка по убыванию
                DGridServic.ItemsSource = ((List<Service>)DGridServic.ItemsSource).OrderByDescending(u => u.Title).ToList();
            }

        }

        private void tbScreac_TextChanged(object sender, TextChangedEventArgs e)
        {
            var searchString = tbScreac.Text;
            DGridServic.ItemsSource = MyClass.ConnectObd.conOdb.Service.Where(u => u.Title.Contains(searchString)).ToList();
        }

        private void BtEdit_Click(object sender, RoutedEventArgs e)
        {
            if (DGridServic.SelectedItem != null)
            {
                var item = DGridServic.SelectedItem as Service;
                NavigationService.Navigate(new PageEditNew(item));
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (DGridServic.SelectedItem != null)
            {
                var item = DGridServic.SelectedItem as Service;
                NavigationService.Navigate(new PageEditNew(item));
            }
        }

        private void DGridServic_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var item = DGridServic.SelectedItem as Service;
            NavigationService.Navigate(new PageEditNew(item));
        }

        private void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            if (Visibility == Visibility.Visible)
            {
                MyClass.ConnectObd.conOdb.ChangeTracker.Entries().ToList().ForEach(p => p.Reload());
                DGridServic.ItemsSource = MyClass.ConnectObd.conOdb.Service.ToList();
            }

        }

        private void AddBtn_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddServicPage2());
        }
    }
}
