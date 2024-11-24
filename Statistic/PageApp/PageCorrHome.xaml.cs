using Statistic.ClassApp;
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
    /// Логика взаимодействия для PageCorrHome.xaml
    /// </summary>
    public partial class PageCorrHome : Page
    {
        public PageCorrHome()
        {
            InitializeComponent();
            MIHome.Header = ClassCorr.CorrHome.Title;
            MIUser.Header = ClassCorr.CorrUser.Name;
        }

        private void CLEventShowUser(object sender, RoutedEventArgs e)
        {
            LitleFrame.NavigationService.Navigate(new LocalPageApp.PageShowUser());
        }

        private void ClEventGoLogin(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверены, что хотите покинуть программу?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                ClassCorr.CorrUser = null; ClassCorr.CorrHome = null;
                NavigationService.Navigate(new PageLogin());
            }    
        }

        private void ClEventGoHomeMenu(object sender, RoutedEventArgs e)
        {
                ClassCorr.CorrHome= null;
                NavigationService.Navigate(new PageMenuHome());
        }
    }
}
