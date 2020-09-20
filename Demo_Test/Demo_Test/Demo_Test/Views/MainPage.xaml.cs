using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Demo_Test.ViewModels;

namespace Demo_Test.Views
{
    public partial class MainPage : ContentPage
    {
        MainViewModel viewModel;
        public MainPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new MainViewModel(Navigation);
        }
    }
}
