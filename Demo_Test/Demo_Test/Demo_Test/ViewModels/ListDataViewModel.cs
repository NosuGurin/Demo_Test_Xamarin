using System;
using System.Collections.Generic;
using System.Text;
using Demo_Test.ViewModels;
using Demo_Test.Interfaces;
using System.Threading.Tasks;
using Xamarin.Forms;
using Demo_Test.Services;
using Demo_Test.Models;

namespace Demo_Test.ViewModels
{
    public class ListDataViewModel : BaseViewModel , IAsyncInitialization
    {
        DataService dataService = new DataService();
        public Task Initialization { get; }
        public INavigation _navigation { get; set; }

        public List<Data_Wheather> List_Data { get; set; }
        public ListDataViewModel(INavigation navigation)
        {
            _navigation = navigation;
            Initialization = InitializationAsync();
        }

        private async Task InitializationAsync()
        {
           var rs =  await dataService.Get_Data_Wheather();
            if (rs != null)
            {
                List_Data = rs.consolidated_weather;
            }
            
        }
    }
}
