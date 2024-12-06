using Statistic.ADOApp;
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
    /// Логика взаимодействия для PageSaportStat.xaml
    /// </summary>
    public partial class PageSaportStat : Page
    {
        public static List<ReadMeters> _readMeters {  get; set; } 
        public PageSaportStat(PeriodsRead _selPeriod)
        {
            InitializeComponent();
            this.DataContext = _selPeriod;   
            _readMeters = new List<ReadMeters>(App.Connection.ReadMeters.Where(z=>z.PR_id == _selPeriod.Id_PR).ToList());
            InsertText();
            InsertProgress();
        }
        private void InsertText()
        {
            foreach (var index in _readMeters.ToList())
            {
                TxtInfo.Content += index.Meters.Title + " " + index.Meters.TypeMeters.Title + " : " + index.Count + " " + index.Meters.TypeMeters.Unit+ "\n";
            }
        }
        private void InsertProgress()
        {
            float _result = 0;
            double _total = 0;
            foreach (var index in _readMeters.ToList())
            {
                _result += index.Count;
                _total += Convert.ToDouble(index.Meters.Price) * index.Count ;
            }
            float _percent = 100 / _result;
            double _percentPrice = 100 / _total;
            StackPanel stackUnit = new StackPanel();
            Label lblUn = new Label();
            lblUn.Content = "Рассчет по расходу";
           
            StackPanel stackPrice = new StackPanel();
            Label lblMon = new Label();
            lblMon.Content = "Рассчет по затратам";
            
            foreach (var index in _readMeters.ToList())
            {
                ProgressBar bar = new ProgressBar();
                bar.Maximum = _result;
                bar.Height = 25;
                bar.Value = index.Count;
                Label lbl = new Label();
                lbl.Content = (_percent * index.Count)+"%/100 \n"+(Convert.ToDouble(index.Meters.Price) * index.Count)+" руб./"+_total + " руб.";
                Label lblTitle = new Label();
                lblTitle.Content = index.Meters.Title + index.Meters.TypeMeters.Title;
                stackUnit.Children.Add(lblTitle);
                stackUnit.Children.Add(bar);
                stackUnit.Children.Add(lbl);
            }
            foreach (var index in _readMeters.ToList())
            {
                ProgressBar bar = new ProgressBar();
                bar.BorderBrush = Brushes.Pink;
                bar.Background = Brushes.Pink;
                bar.Foreground= Brushes.Maroon;
                bar.Maximum = _total;
                bar.Height = 25;
                bar.Value = (Convert.ToDouble(index.Meters.Price) * index.Count);
                Label lbl = new Label();
                lbl.Content = (_percentPrice * (Convert.ToDouble(index.Meters.Price) * index.Count)) + "Руб./" + _total + " руб.";
                Label lblTitle = new Label();
                lblTitle.Content = index.Meters.Title + index.Meters.TypeMeters.Title;
                stackPrice.Children.Add(lblTitle);
                stackPrice.Children.Add(bar);
                stackPrice.Children.Add(lbl);
            }
            StackProgress.Children.Add(lblUn);
            StackProgress.Children.Add(stackUnit);
            StackProgress.Children.Add(lblMon);
            StackProgress.Children.Add(stackPrice);
        }
    }
}
