using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MaderaDevisBuilder.ViewModels
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        public void ToggleSidebar(object sender, EventArgs e)
        {
            App.MenuIsPresented = !App.MenuIsPresented;
        }
    }
}
