using System;
using System.Collections.Generic;
using MaderaDevisBuilder.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaderaDevisBuilder.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        public LoginViewModel viewModel { get; set; } = new LoginViewModel();

        public LoginPage()
        {
            InitializeComponent();
            BindingContext = viewModel;

            mail.Completed += (sender, args) => { pass.Focus(); };

        }
    }
}
