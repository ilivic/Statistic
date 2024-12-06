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
    /// Логика взаимодействия для PagePushParam.xaml
    /// </summary>
    public partial class PagePushParam : Page
    {
        private List<foMeter> _localListMeters  {  get; set; }
        public PagePushParam()
        {
            InitializeComponent();
            GetPeriod();
            insertData();
            ListMeters.ItemsSource = _localListMeters.ToList();
        }
        private void GetPeriod()
        {
            if (ClassCorr.CorrHome.Periods.Id_period == 2)
            {
                TxtPeriod.Text = DateTime.Now.ToString("yyyy");
                var _chec = App.Connection.PeriodsRead.Where(z=>z.id_obj == ClassCorr.CorrHome.Id_OBJ && z.DateP.Year == DateTime.Now.Year).FirstOrDefault();
                if (_chec != null)
                {
                    MessageBox.Show($"вы уже подали показания за данный период {_chec.DateP.Year}");
                    this.IsEnabled = false;
                }
            }
            else
            { 
                TxtPeriod.Text = DateTime.Now.ToString("MMMM");
                var _chec = App.Connection.PeriodsRead.Where(z => z.id_obj == ClassCorr.CorrHome.Id_OBJ && z.DateP.Month == DateTime.Now.Month).FirstOrDefault();
                if (_chec != null)
                {
                    MessageBox.Show($"вы уже подали показания за данный период {_chec.DateP.Month}");
                    this.IsEnabled = false;
                }
            }
        }
        private void insertData()
        {
            _localListMeters = new List<foMeter>();
            foreach (var index in App.Connection.Meters.Where(z => z.OBJ_id == ClassCorr.CorrHome.Id_OBJ).ToList())
            {
                _localListMeters.Add(new foMeter()
                {
                    meters = index,
                    title = index.Title,
                    info = index.TypeMeters.Title,
                    count = 0,
                }
                );
            }
        }
        private class foMeter
        {
            public  Meters meters {  get; set; }
            public  string title {  get; set; }
            public  string info {  get; set; }
            public  float count {  get; set; }
        }

        private void ClEventPush(object sender, RoutedEventArgs e)
        {

            try
            {
                var _period = new PeriodsRead()
                {
                    OBJ = ClassCorr.CorrHome,
                    Periods = ClassCorr.CorrHome.Periods,
                    DateP = DateTime.Now.Date,
                };
                App.Connection.PeriodsRead.Add(_period);
                foreach (var index in _localListMeters)
                {
                    App.Connection.ReadMeters.Add(new ReadMeters()
                    {
                        Count = index.count,
                        PeriodsRead = _period,
                        Meters = index.meters
                    });

                }
                App.Connection.SaveChanges();
                MessageBox.Show("Показания за период поданы. \nCтатистику вы можете увидеть на вкладке просмотреть историю");
                NavigationService.Navigate(new PagePushHistStat());

            }
            catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }

           
        }
    }
}
