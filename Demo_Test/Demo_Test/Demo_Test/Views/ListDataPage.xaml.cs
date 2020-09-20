using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Demo_Test.ViewModels;

namespace Demo_Test.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ListDataPage : ContentPage
    {
        ListDataViewModel viewModel;
        public ListDataPage()
        {
            InitializeComponent();
            BindingContext = viewModel = new ListDataViewModel(Navigation);
        }
    }
}