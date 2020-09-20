using System;
using System.Collections.Generic;
using System.Text;
using Demo_Test.ViewModels;
using Demo_Test.Interfaces;
using System.Threading.Tasks;
using Xamarin.Forms;
using System.Windows.Input;
using Demo_Test.Views;

namespace Demo_Test.ViewModels
{
    public class MainViewModel : BaseViewModel , IAsyncInitialization
    {
        public Task Initialization { get; }
        public INavigation _navigation { get; set; }

        public ICommand Web_View { get; private set; }
        public ICommand List_Data { get; private set; }
        public MainViewModel(INavigation navigation)
        {
            _navigation = navigation;

            Web_View = new Command(async () => await _navigation.PushAsync(new WebPage())) ;

            List_Data = new Command(async () => await _navigation.PushAsync(new ListDataPage())); ;
        }
    }
}
