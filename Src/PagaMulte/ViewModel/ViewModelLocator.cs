using GalaSoft.MvvmLight.Ioc;
using Microsoft.Practices.ServiceLocation;
using PagaMulte.Interfaces;
using PagaMulte.ModelLayer;
using PagaMulte.Services;
using Xamarin.Forms;
using System.Collections.Generic;

namespace PagaMulte.ViewModel
{
    /// <summary>
    /// This class contains static references to all the view models in the
    /// application and provides an entry point for the bindings.
    /// </summary>
    public class ViewModelLocator
    {
        public string _userCorrente;
      
        public LoginViewModel LoginVm => ServiceLocator.Current.GetInstance<LoginViewModel>();
        public HomeViewModel HomeVm => ServiceLocator.Current.GetInstance<HomeViewModel>();

        public static INavigation Navigation { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the ViewModelLocator class.
        /// </summary>
        public ViewModelLocator()
        {
            //Resources.Resources.Culture = DependencyService.Get<ILocalize>()?.GetCurrentCultureInfo();
            
            ServiceLocator.SetLocatorProvider(() => SimpleIoc.Default);
            SimpleIoc.Default.Register<LoginViewModel>();
            SimpleIoc.Default.Register<HomeViewModel>();
          
            SimpleIoc.Default.Register<INavigationService>(() => new NavigationService(Navigation));
            
        }

        public static void Cleanup()
        {
            // TODO Clear the ViewModels
        }
    }
}
