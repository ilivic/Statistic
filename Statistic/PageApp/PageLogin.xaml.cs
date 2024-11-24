using Statistic.ClassApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
    /// Логика взаимодействия для PageLogin.xaml
    /// </summary>
    public partial class PageLogin : Page
    {
        public PageLogin()
        {
            InitializeComponent();
        }

        private void ClEventReg(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageReg());
        }

        private void ClEventAutho(object sender, RoutedEventArgs e)
        {
            try
            {
                var _sel = App.Connection.Users.Where(z => z.Login == TxtLogin.Text && z.password == TxtPassword.Password).FirstOrDefault();
                if (_sel != null)
                {
                    ClassCorr.CorrUser = _sel;
                    MessageBox.Show($"Добро пожаловать {_sel.Name}");
                    NavigationService.Navigate(new PageMenuHome());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
