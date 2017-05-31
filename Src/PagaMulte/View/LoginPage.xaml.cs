using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagaMulte.ViewModel;
using Xamarin.Forms;

namespace PagaMulte.View
{
    public partial class LoginPage : ContentPage
    {
        public LoginPage()
        {
            InitializeComponent();
            ViewModelLocator.Navigation = Navigation;
            BindingContext = App.Locator.LoginVm;
        }
    }
}
