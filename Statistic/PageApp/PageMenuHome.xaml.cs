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

namespace Statistic.PageApp
{
    /// <summary>
    /// Логика взаимодействия для PageMenuHome.xaml
    /// </summary>
    public partial class PageMenuHome : Page
    {
        public static List<OBJ> _Home {  get; set; }
        public PageMenuHome()
        {
            InitializeComponent();
            _Home = new List<OBJ>(App.Connection.OBJ.Where(z => z.User_id == ClassCorr.CorrUser.Id_User));
            _Home.Add(new OBJ()
            {
                Title = "Добавить +"
            });
            ListHome.ItemsSource = _Home;
        }

        private void ListHome_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            var _sel = (sender as ListView).SelectedItem as OBJ;
            if (_sel != null)
            {
                if (_sel.Title == "Добавить +")
                {
                    NavigationService.Navigate(new PageAddHome());
                }
                else
                {
                    ClassCorr.CorrHome = _sel;
                    NavigationService.Navigate(new PageCorrHome());
                }
            }
        }
    }
}
