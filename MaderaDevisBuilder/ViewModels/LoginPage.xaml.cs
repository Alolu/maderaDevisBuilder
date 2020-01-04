using System;
using MaderaDevisBuilder.Models;
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
            NavigationPage.SetHasNavigationBar(this, false);
            InitializeComponent();
            BindingContext = viewModel;
            NavigationPage.SetHasBackButton(this, false);
        }

        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        async void OnNextPageButtonClicked(object sender, EventArgs e)
        {
            if (viewModel.CheckCredentials())
            {
                await Navigation.PushAsync(new MenuPage());
            }
        }
    }
}
