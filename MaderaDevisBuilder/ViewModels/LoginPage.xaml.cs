using System;
using MaderaDevisBuilder.Models;
using MaderaDevisBuilder.Services;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaderaDevisBuilder.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginViewModel viewModel { get; set; } = new LoginViewModel();

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = viewModel;
            NavigationPage.SetHasBackButton(this, false);
            mail.Completed += (sender, args) => { pass.Focus(); };

        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new MenuPage());
        }
    }
}
