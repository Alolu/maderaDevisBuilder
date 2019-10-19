using System;
using System.Threading.Tasks;

namespace MaderaDevisBuilder.Services
{
    public interface INavigationService
    {
        string CurrentPage { get; }

        void Configure(string pageKey, Type pageType);
        Task GoBack();
        Task NavigateModalAsync(string pageKey, object options);
        Task NavigateAsync(string pageKey, object options);
    }
}
