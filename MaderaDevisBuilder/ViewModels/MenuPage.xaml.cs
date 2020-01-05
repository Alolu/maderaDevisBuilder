using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace MaderaDevisBuilder.ViewModels
{
    public partial class MenuPage : ContentPage
    {
        public List<string> Items { get; set; } = new List<string>()
        {
            "Léo Borniche",
            "Jérome Dupire",
            "Vanessa Merle",
            "Romain Bouchez",
            "Alexis Planchon",
            "Jimmy Turpin",
            "Charles Theteen",
            "Michel Saouma",
            "Vincent Fouger",
            "Ambroise De Lima"
        };

        public MenuPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
            BindingContext = this;
        }
        protected override bool OnBackButtonPressed()
        {
            return true;
        }
    }
}
