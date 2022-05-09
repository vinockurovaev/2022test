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
    /// Логика взаимодействия для PageEditNew.xaml
    /// </summary>
    public partial class PageEditNew : Page
    {
        public PageEditNew(Service u)
        {
            InitializeComponent();
            MyService = u;
        }
        public Service MyService { get; set; }
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            MyClass.ConnectObd.conOdb.Service.Add(MyService);
            MyClass.ConnectObd.conOdb.SaveChanges();
            NavigationService.GoBack();
        }
    }
}
