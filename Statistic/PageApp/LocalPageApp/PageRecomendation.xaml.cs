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
    /// Логика взаимодействия для PageRecomendation.xaml
    /// </summary>
    public partial class PageRecomendation : Page
    {
        public PageRecomendation()
        {
            InitializeComponent();
            var _rec = App.Connection.TypeRecome.ToList();
            var _recSpec = App.Connection.TypeSpecialRecom.ToList();
            ListRec.ItemsSource = _rec;
            ListSpecRec.ItemsSource = _recSpec;
        }
    }
}
