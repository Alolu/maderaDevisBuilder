using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MaderaDevisBuilder.Services
{
    public class BaseNavigationService : INavigationService
    {

        private readonly object _sync = new object();
        private readonly Dictionary<string, Type> _pagesByKeys = new Dictionary<string,Type>();
        private readonly Stack<NavigationPage> _navigationPageStack = new Stack<NavigationPage>();
        private NavigationPage CurrentNavigationPage => _navigationPageStack.Peek();

        public BaseNavigationService(string pageKey, Type pageType)
        {
            lock (_sync)
            {
                if (_pagesByKeys.ContainsKey(pageKey))
                {
                    _pagesByKeys[pageKey] = pageType;
                }
                else
                {
                    _pagesByKeys.Add(pageKey, pageType);
                } 
            }
        }

        public Page SetRootPage(string rootPageKey)
        {
            var rootPage = GetPage(rootPageKey);
            var mainPage = new NavigationPage(rootPage);
            _navigationPageStack.Clear();
            _navigationPageStack.Push(mainPage);
            return mainPage;
        }

        public Page GetPage(string pageKey, object parameter = null)
        {
            lock (_sync)
            {
                if (!_pagesByKeys.ContainsKey(pageKey))
                {
                    throw new ArgumentException(
                        $"La page {pageKey} n'existe pas, elle n'a peut-être pas été configurée avec NavigationSercice.configure() ?"
                    );
                }

                var type = _pagesByKeys[pageKey];
                ConstructorInfo constructor;
                object[] parameters;

                if(parameter == null)
                {
                    constructor = type.GetTypeInfo()
                        .DeclaredConstructors
                        .FirstOrDefault(c => !c.GetParameters().Any());
                    parameters = new object[] { };
                }
                else
                {
                    constructor = type.GetTypeInfo()
                        .DeclaredConstructors
                        .FirstOrDefault(
                            c => {
                                var p = c.GetParameters();
                                return p.Length == 1 && p[0].ParameterType == parameter.GetType();
                            }
                        );
                    parameters = new[]
                    {
                        parameter
                    };
                }

                if(constructor == null)
                {
                    throw new InvalidOperationException(
                        "Pas de constructeur existant pour " + pageKey
                    );
                }

                var page = constructor.Invoke(parameters) as Page;
                return page;
            }
        }

        public string CurrentPage => throw new NotImplementedException();

        public void Configure(string pageKey, Type pageType)
        {
            throw new NotImplementedException();
        }

        public Task GoBack()
        {
            throw new NotImplementedException();
        }

        public Task NavigateAsync(string pageKey, object options)
        {
            throw new NotImplementedException();
        }

        public Task NavigateModalAsync(string pageKey, object options)
        {
            throw new NotImplementedException();
        }
    }
}
