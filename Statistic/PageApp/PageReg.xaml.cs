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
    /// Логика взаимодействия для PageReg.xaml
    /// </summary>
    public partial class PageReg : Page
    {
        public static byte[] _image {  get; set; }
        public PageReg()
        {
            InitializeComponent();
        }

        private void CLEventRevers(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new PageLogin());
        }

        private void ClEventGetPhoto(object sender, RoutedEventArgs e)
        {
            var _sel = ClassApp.ImageWork.GetImage();
            if (_sel != null)
            {
                _image = _sel;
            }
        }

        private void ClEventAddNewUser(object sender, RoutedEventArgs e)
        {
            if (TxtName.Text != "" && TxtLogin.Text != "" && TxtPassword.Text != "")
            {
                var answer = UsersTableWork.AddNewUser(TxtName.Text, TxtLogin.Text, TxtPassword.Text, TxtEmail.Text, _image);
                if (answer == true)
                {
                    NavigationService.Navigate(new PageLogin());
                }
                else
                {

                }
            }
        }
    }
}
