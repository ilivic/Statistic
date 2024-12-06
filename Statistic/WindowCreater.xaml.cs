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
using System.Windows.Shapes;

namespace Statistic
{
    /// <summary>
    /// Логика взаимодействия для WindowCreater.xaml
    /// </summary>
    public partial class WindowCreater : Window
    {
        public WindowCreater()
        {
            InitializeComponent();
        }

        private void ClEventExit(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
