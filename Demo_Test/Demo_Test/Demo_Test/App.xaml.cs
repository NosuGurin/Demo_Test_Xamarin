using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Demo_Test.Views;
using SQLite;
using System.Globalization;
using Demo_Test.Models;

namespace Demo_Test
{
    public partial class App : Application
    {
        private SQLiteConnection _sqLiteConnection;
        public App()
        {
            InitializeComponent();
            Device.SetFlags(new[] { "Shapes_Experimental", "Expander_Experimental" });


            var culture = new CultureInfo("en");
            culture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";
            culture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy HH:mm:ss";
            CultureInfo.DefaultThreadCurrentCulture = culture;

            _sqLiteConnection = DependencyService.Get<ISQLite>().GetConnection();
            TaoDB();
            var check_data = _sqLiteConnection.Table<Login_Data>().FirstOrDefault();

            if (check_data != null)
            {

                MainPage = new NavigationPage(new MainPage());

            }
            else
            {
                
                MainPage = new LoginPage();
            }
        }


        public void TaoDB()
        {
            _sqLiteConnection.CreateTable<Login_Data>();
        }
        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
