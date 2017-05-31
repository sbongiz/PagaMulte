using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using PagaMulte.Interfaces;
using PagaMulte.View;
using Xamarin.Forms;
using System.Threading;

namespace PagaMulte.ViewModel
{

    public class LoginViewModel : ViewModelBase
    {
        private RelayCommand _btnAccediClick;
        private string _username;
        private string _password;

        public LoginViewModel()
        {
           
        }

        #region Property
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                Set(ref _username, value);
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                Set(ref _password, value);
            }
        }

        #endregion

        #region Command
        public RelayCommand BtnAccediClick
        {
            get
            {
                if (_btnAccediClick == null)
                {

                    _btnAccediClick = new RelayCommand(() =>
                    {





                        App.Current.MainPage = new NavigationPage(new HomePage());
                    }, () => true);
                }
                return _btnAccediClick;
            }

        }
        #endregion

        #region Function

        #endregion
    }
}
