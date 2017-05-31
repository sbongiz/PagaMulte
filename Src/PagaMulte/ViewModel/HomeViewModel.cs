using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PagaMulte.Interfaces;
using PagaMulte.View;
using Xamarin.Forms;
using System.Threading;
using System;
using System.Diagnostics.Contracts;
using System.Threading.Tasks;
using System.Linq.Expressions;
using PagaMulte.ModelLayer;


namespace PagaMulte.ViewModel
{
    public class HomeViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        public HomeViewModel(INavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        #region Property

        #endregion

        #region Command

        #endregion

        #region Function

        #endregion

    }
}


