using Demo_Test.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Demo_Test.Apis;

namespace Demo_Test.Services
{
    public class DataService
    {
        private readonly SQLiteConnection _sqLiteConnection;
        GetDataApi GetDataApi = new GetDataApi();
        //LoginApi logApi = new LoginApi();

        public DataService()
        {
            _sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection();

        }

        public async Task<ListData<Data_Wheather>> Get_Data_Wheather()
        {
            ListData<Data_Wheather> result = new ListData<Data_Wheather>();
            result = await GetDataApi.Get_Data_WheatherAsync();
            return result;
        }
    }
}
