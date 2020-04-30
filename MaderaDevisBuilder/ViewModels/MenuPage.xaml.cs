using System;
using System.Collections.Generic;
using MaderaDevisBuilder.DAO;
using MaderaDevisBuilder.Models;
using Xamarin.Forms;

namespace MaderaDevisBuilder.ViewModels
{
    public partial class MenuPage : ContentPage
    {

        public List<Client> Items { get; set; } = ClientDao.Clients;

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

        public void ToggleSidebar(object sender, EventArgs e)
        {
            App.MenuIsPresented = !App.MenuIsPresented;
        }

        public void OnAddClicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DevisPage());
        }
    }
}
