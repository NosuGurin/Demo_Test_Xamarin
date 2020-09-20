using Demo_Test.Interfaces;
using Demo_Test.Services;
using Demo_Test.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo_Test.ViewModels
{
    public class LoginViewModel : BaseViewModel, IAsyncInitialization
    {
        public Task Initialization { get; }
        public INavigation _navigation { get; set; }
        LoginService loginService = new LoginService();
        
        string username;
        public string UserName
        {
            get { return username; }
            set => RaiseIfPropertyChanged(ref username, value);

        }
        string password;
        public string Password
        {
            get { return password; }
            set => RaiseIfPropertyChanged(ref password, value);

        }
        string status;
        public string Status
        {
            get { return status; }
            set => RaiseIfPropertyChanged(ref status, value);

        }
        public Command Xuly { get; }
        public LoginViewModel()
        {

            var datauser = loginService.GetInfo();
            if (datauser != null)
            {
                UserName = datauser.Email;
                Password = datauser.Password;
            }
            Xuly = new Command(async () => await Login());
            //Initialization = InitializationAsync();
        }

        

        async Task Login()
        {

            IsBusy = true;
            Status = "Đang thực thi";

            try
            {
                var rs = await loginService.Login(UserName, Password);
                if (rs == true)
                {
                    
                        Status = "Login thành công";
                        IsBusy = false;

                        Application.Current.MainPage = new NavigationPage(new MainPage());

                    
                }
                else
                {
                    Status = "Vui lòng kiểm tra lại thông tin đăng nhập !";
                    IsBusy = false;
                    await App.Current.MainPage.DisplayAlert("Thông Báo", "Vui lòng kiểm tra lại thông tin đăng nhập", "Đóng");
                }

            }

            catch (Exception)
            {
                Status = "Vui lòng kiểm tra lại thông tin đăng nhập!";
                IsBusy = false;
                await App.Current.MainPage.DisplayAlert("Thông Báo", "Vui lòng kiểm tra lại thông tin đăng nhập", "Đóng");
                //await Navigation.PushAsync(new Alert("Bạn Chưa Bật Vị Trí, Vui Lòng Bật Chia Sẽ Vị ! ", "#db2828"));
            }

        }
    }
}
