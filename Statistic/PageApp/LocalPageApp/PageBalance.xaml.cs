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
    /// Логика взаимодействия для PageBalance.xaml
    /// </summary>
    public partial class PageBalance : Page
    {
        public PageBalance()
        {
            InitializeComponent();
            this.DataContext = ClassCorr.CorrUser;
        }

        private void ClEventSaveBalance(object sender, RoutedEventArgs e)
        {
            try
            { 
                App.Connection.SaveChanges();
            }
            catch (Exception Ex) 
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
