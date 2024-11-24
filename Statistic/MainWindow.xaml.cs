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

namespace Statistic
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int Index {  get; set; }
        public MainWindow()
        {
            InitializeComponent();
            MianFrame.NavigationService.Navigate(new PageApp.PageLogin());
            Index = 0;
        }

        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void ClEventExit(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("Вы уверенны, что хотите закрыть программу?", "", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            { 
                this.Close();
            }
        }

        private void ClEventHidden(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void ClEventChTheme(object sender, RoutedEventArgs e)
        {
            if (Index == 0)
            {
                this.Background = Brushes.Gray;
                Index = 1;
            }
            else
            {
                this.Background = Brushes.White;
                Index = 0;
            }

        }
    }
}
