using Demo_Test.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo_Test.Services
{
    public class LoginService
    {
        private readonly SQLiteConnection _sqLiteConnection;

        //LoginApi logApi = new LoginApi();

        public LoginService()
        {
            _sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection();

        }
        public Login_Data GetInfo()
        {
            return _sqLiteConnection.Table<Login_Data>().FirstOrDefault();
        }

        public async Task<bool> Login(string user,string pass)
        {
            if (user == "viet.tran.business@gmail.com" && pass == "Abc@123456")
            {
                Login_Data login_Data = new Login_Data();
                login_Data.Email = user;
                login_Data.Password = pass;

                _sqLiteConnection.Insert(login_Data);
                return true;
            }
            return false;
        }
    }
}
