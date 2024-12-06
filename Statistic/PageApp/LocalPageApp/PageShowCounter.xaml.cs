using MahApps.Metro.Controls.Dialogs;
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
using System.Windows.Forms;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Statistic.PageApp.LocalPageApp
{
    /// <summary>
    /// Логика взаимодействия для PageShowCounter.xaml
    /// </summary>
    public partial class PageShowCounter : Page
    {
        public PageShowCounter()
        {
            InitializeComponent();
            ListMeters.ItemsSource = App.Connection.Meters.Where(z=>z.OBJ_id == ClassCorr.CorrHome.Id_OBJ).ToList();
        }

        private void ListMeters_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (ListMeters.SelectedItem != null)
            {
                var _sel = (ListMeters.SelectedItem as Meters);
                if ( System.Windows.MessageBox.Show($"вы уверенны, что хотите удалить \n{_sel.Title.ToString()}","",MessageBoxButton.YesNo) == MessageBoxResult.Yes)
                {
                    App.Connection.Meters.Remove( _sel );
                    App.Connection.SaveChanges();
                    NavigationService.Navigate(new PageShowCounter());
                }
            }
        }
    }
}
