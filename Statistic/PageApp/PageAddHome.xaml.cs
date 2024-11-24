using Statistic.ADOApp;
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

namespace Statistic.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageAddHome.xaml
    /// </summary>
    public partial class PageAddHome : Page
    {
        public PageAddHome()
        {
            InitializeComponent();
            CmbPeriod.ItemsSource = App.Connection.Periods.ToList();
        }

        private void ClEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageMenuHome());
        }

        private void ClEventAddNewHome(object sender, RoutedEventArgs e)
        {
            if (TxtAdress.Text != "" && TxtTitle.Text != "")
            {
                var _period = CmbPeriod.SelectedItem as Periods;
                if (_period != null)
                {
                    var _sel = ClassApp.ObjTableWork.AddNewObj(TxtTitle.Text, TxtAdress.Text, _period.Id_period);
                    if (_sel == true)
                    {
                        NavigationService.Navigate(new PageMenuHome());
                    }
                    else
                    {

                    }
                }
            }
        }
    }
}
