using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using Statistic.ADOApp;

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
}
