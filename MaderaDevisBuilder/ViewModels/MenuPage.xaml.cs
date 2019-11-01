using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MaderaDevisBuilder.ViewModels
{
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
            NavigationPage.SetHasBackButton(this, false);
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
