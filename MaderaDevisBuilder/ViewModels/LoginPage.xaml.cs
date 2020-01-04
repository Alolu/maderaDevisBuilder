using System;
using MaderaDevisBuilder.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MaderaDevisBuilder.ViewModels
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {

        public LoginPage()
        {
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
        }

        //Empeche de retourner a la derniere page en appuyant sur le bouton retour
        protected override bool OnBackButtonPressed()
        {
            return true;
        }

        //Baisse l'opacité du bouton progressivement (Animation)
        void RemoveOpacity(object sender, EventArgs e)
        {
            Entry input = (Entry)sender;
            input.FadeTo(0.5, 1000);
        }

        //Augmente l'opacité du bouton progressivement (Animation)
        void AddOpacity(object sender, EventArgs e)
        {
            Entry input = (Entry)sender;
            input.FadeTo(1, 1000);
        }

        //Echange l'input de mail avec celui de password, et ensuite affiche le menu. (Animation)
        void ShowNext(object sender, EventArgs e)
        {
            if (EmailEntry.IsVisible)
            {
                EmailEntry.FadeTo(0, 300, Easing.SinIn);
                EmailEntry.IsVisible = false;
                PassEntry.IsVisible = true;
                PassEntry.FadeTo(1, 300, Easing.SinOut);
                PassEntry.Focus();
            }
            else
            {
                Navigation.PushAsync(new MenuPage());
            }
        }
    }
}
