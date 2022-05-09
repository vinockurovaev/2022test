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
    /// Interaction logic for AddServicPage.xaml
    /// </summary>
    public partial class AddServicPage : Page
    {
        private Service _currentService = new Service();
        public AddServicPage()
        {
            InitializeComponent();
            DataContext = _currentService;

        }
        
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if (_currentService.ID == 0)
             MyClass.ConnectObd.conOdb.Service.Add(_currentService);
            MyClass.ConnectObd.conOdb.SaveChanges();
            NavigationService.GoBack();

        }
    }
}
