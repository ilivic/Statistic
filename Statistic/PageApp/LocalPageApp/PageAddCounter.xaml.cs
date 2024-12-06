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
    /// Логика взаимодействия для PageAddCounter.xaml
    /// </summary>
    public partial class PageAddCounter : Page
    {
        public PageAddCounter()
        {
            InitializeComponent();
            CmbTypeCounter.ItemsSource = App.Connection.TypeMeters.ToList();
        }

        private void ClEventAddMeters(object sender, RoutedEventArgs e)
        {
            try
            {
                if (TxtPrice.Text != "" && TxtTitle.Text != "")
                {
                    var _sel = CmbTypeCounter.SelectedItem as TypeMeters;
                    if (_sel!=null)
                    {
                        var answer = MetersTableWork.AddNewMeters(TxtTitle.Text,Convert.ToDecimal(TxtPrice.Text),_sel.Id_TM);
                        if (answer == true)
                        {
                            NavigationService.Navigate(new PageShowCounter());
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Видимо вы неверно зполнили данные");
            }
        }
    }
}
