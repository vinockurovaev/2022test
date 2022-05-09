﻿using System;
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
    /// Interaction logic for PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
        }

        private void btnService_Click(object sender, RoutedEventArgs e)
        {
          
           NavigationService.Navigate(new MyPages.ServicPage());
        }

        private void btnProduct_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new MyPages.ServisListPage());
        }
    }
}
