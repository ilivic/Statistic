using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Statistic.ADOApp;
using System.Globalization;
using System.Web.UI.WebControls.WebParts;
using _excel = Microsoft.Office.Interop.Excel;
using Page = System.Windows.Controls.Page;
using Microsoft.Office.Interop.Excel;

namespace Statistic.ClassApp
{
    internal class ClassAllEvent
    {

    }
    public class ImageWork
    {
        public static byte[] GetImage()
        {
            try
            {
                OpenFileDialog ofd = new OpenFileDialog();
                ofd.Filter = "изображение |*.jpg;*.png;*.BMP;*.jpeg";
                ofd.Multiselect = false;
                ofd.ShowDialog();
                if (ofd.FileName != null)
                {
                    return File.ReadAllBytes(ofd.FileName);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

    }
    public class ObjTableWork
    {
        public static Boolean AddNewObj(string _title, string _adress,int _periods)
        {
            try
            {
                App.Connection.OBJ.Add(new OBJ()
                {
                    Title = _title,
                    Adress = _adress,
                    Period_id = _periods,
                    DataAdd = DateTime.Now.Date.Date,
                    User_id = ClassCorr.CorrUser.Id_User,
                });
                App.Connection.SaveChanges();
                MessageBox.Show("Добавление прошло успешно");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }

    public class UsersTableWork
    {
        public static Boolean AddNewUser(string _name,string _login,string _password,string _email, byte[] _image)
        {
            try
            {
                var _new = new Users()
                {
                    Name = _name,
                    Login = _login,
                    password = _password,
                    Photo = _image,
                    Email = _email,
                    Balance = 0,
                    DateRegist = DateTime.Now.Date.Date,
                };
                App.Connection.Users.Add(_new);
                App.Connection.SaveChanges();
                MessageBox.Show("Регистрация прошла успешно");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
    public class foExportList
    {
        public string MetersTitle { get; set; }
        public string TypeMetersTitl { get; set; }
        public float count { get; set; }
        public string unit { get; set; }
        public DateTime Date { get; set; }
    }
    public class Statist
    {
        public static List<PeriodsRead> _perMeters { get; set; }
        public static void InsertText()
        {
            var _exportData = new List<foExportList>();
            _perMeters = new List<PeriodsRead>(App.Connection.PeriodsRead.Where(z=>z.id_obj == ClassCorr.CorrHome.Id_OBJ).ToList());
            foreach (var i in _perMeters.ToList())
            {
                
                var _readMeters = App.Connection.ReadMeters.Where(z=>z.PeriodsRead.Id_PR == i.Id_PR).ToList();
                foreach (var index in _readMeters.ToList())
                {
                    var _expd = new foExportList();
                    _expd.MetersTitle = index.Meters.Title;
                    _expd.TypeMetersTitl = index.Meters.TypeMeters.Title;
                    _expd.count = index.Count;
                    _expd.unit = index.Meters.TypeMeters.Unit;
                    _expd.Date = i.DateP;
                    _exportData.Add(_expd);
                }
            }

            foExportData(_exportData);
        }
        private static void foExportData (List<foExportList> date)
        {
           
            _Application excel = new _excel.Application();
            Workbook _wb;
            Worksheet _ws;
            _wb = excel.Workbooks.Add();
            _ws = _wb.Worksheets[1];
            var j = 1;
            foreach (var index in date)
            {
                _excel.Range column_date = _ws.Cells[j, 1];
                column_date.NumberFormat = "yyyy:MMMM";
                _ws.Cells[j, 1].Value2 = index.Date;
                _ws.Cells[j, 2].Value2 = index.MetersTitle;
                _ws.Cells[j, 3].Value2 = index.TypeMetersTitl;
                _ws.Cells[j, 4].Value2 = index.count;
                _ws.Cells[j, 5].Value2 = index.unit;
                j++;
                j++;
         
            }
            _wb.SaveAs("Показания.xlsx");
            _wb.Close();
            MessageBox.Show("Список показания за периоды в папке документы");
        }
    }
    


    public class MetersTableWork
    {
        public static Boolean AddNewMeters(string _title, decimal _price, int _type)
        {
            try
            {
                App.Connection.Meters.Add(new Meters()
                {
                    Title = _title,
                    Price = _price,
                    Type_id = _type,
                    OBJ_id = ClassCorr.CorrHome.Id_OBJ,
                });
                App.Connection.SaveChanges();
                MessageBox.Show("счетчик добавлен");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }
    }
}
