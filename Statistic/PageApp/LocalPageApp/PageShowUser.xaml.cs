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
    /// Логика взаимодействия для PageShowUser.xaml
    /// </summary>
    public partial class PageShowUser : Page
    {
        public PageShowUser()
        {
            InitializeComponent();
            this.DataContext = ClassCorr.CorrUser;
        }

        private void ClEventChUser(object sender, RoutedEventArgs e)
        {
            var _sel = sender as Button;
            if (_sel.Content.ToString() == "редактировать")
            {
                _sel.Content = "сохранить";
                TxtEmail.IsEnabled = true;
                TxtLogin.IsEnabled = true;
                TxtName.IsEnabled = true;
                TxtPassword.IsEnabled = true;
            }
            else 
            {
                if (TxtName.Text != "" && TxtLogin.Text != "" && TxtPassword.Text != "")
                {
                    TxtEmail.IsEnabled = false;
                    TxtLogin.IsEnabled = false;
                    TxtName.IsEnabled = false;
                    TxtPassword.IsEnabled = false;
                    App.Connection.SaveChanges();
                    _sel.Content = "редактировать";
                }
            }
        }
    }
}
