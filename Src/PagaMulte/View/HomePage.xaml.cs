using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PagaMulte.ViewModel;
using PagaMulte.ModelLayer;
using Xamarin.Forms;


using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Diagnostics;

namespace PagaMulte.View
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            ViewModelLocator.Navigation = Navigation;
            BindingContext = App.Locator.HomeVm;

            #region Toolbar
            //TOOLBAR
            var tbi = new ToolbarItem("Option1", "", () =>
            {
                //Click di Option1
                // var todoPage = new TodoItemPage();
                //Navigation.PushAsync(todoPage);

            }, 0, 0);
            tbi.Order = ToolbarItemOrder.Secondary;  // forces it to appear in menu on Android
            ToolbarItems.Add(tbi);
            var tbi2 = new ToolbarItem("Option2", "", () =>
            {
                //Click di Option2
            }, 0, 0);
            ToolbarItems.Add(tbi2);

            tbi2.Order = ToolbarItemOrder.Secondary; // forces it to appear in menu on Android
            #endregion

            var vm = (HomeViewModel)this.BindingContext;
        }
    }
}
