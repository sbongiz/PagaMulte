using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using PagaMulte.Interfaces;
using Xamarin.Forms;

namespace PagaMulte.Services
{
    class NavigationService : INavigationService
    {
        private readonly INavigation _navigation;

        public NavigationService(INavigation navigation)
        {
            _navigation = navigation;
        }

        public void RemovePage(Page page)
        {
            _navigation.RemovePage(page);
        }

        public Task PushAsync(Page page)
        {
            return _navigation.PushAsync(page);
        }


        public void InsertPageBefore(Page page, Page before)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Esegue la navigazione
        /// </summary>
        /// <param name="page">la pagina nella quale navigare</param>
        /// <param name="modal">se è 1 allora la navigazione non tiene conto dello stack di navigazione, se è 0 tiene conto</param>
        /// <returns></returns>
        public Task PushAsync(Page page, int modal)
        {
            if (modal == 1)
                return _navigation.PushModalAsync(page);
            else
                return _navigation.PushAsync(page);
        }

        public Task<Page> PopAsync()
        {
            return _navigation.PopAsync();
        }

        public Task PopToRootAsync()
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(Page page)
        {
            return _navigation.PushModalAsync(page);
        }

        public Task<Page> PopModalAsync()
        {
            throw new NotImplementedException();
        }

        public Task PushAsync(Page page, bool animated)
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PopToRootAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public Task PushModalAsync(Page page, bool animated)
        {
            throw new NotImplementedException();
        }

        public Task<Page> PopModalAsync(bool animated)
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<Page> NavigationStack { get; }
        public IReadOnlyList<Page> ModalStack { get; }
    }
}

