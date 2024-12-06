using Statistic.ADOApp;
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

namespace Statistic.PageApp.LocalPageApp
{
    /// <summary>
    /// Логика взаимодействия для PagePushHistStat.xaml
    /// </summary>
    public partial class PagePushHistStat : Page
    {
        public PagePushHistStat()
        {
            InitializeComponent();
            ListPeriods.ItemsSource = App.Connection.PeriodsRead.Where(z => z.id_obj == ClassCorr.CorrHome.Id_OBJ).ToList();
        }

        private void ListPeriods_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListPeriods.SelectedItem != null)
            {
                var _sel = ListPeriods.SelectedItem as PeriodsRead;
                SaportFrame.NavigationService.Navigate(new PageSaportStat(_sel));
            }
        }
    }
}
