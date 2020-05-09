using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MaderaDevisBuilder.DAO;
using MaderaDevisBuilder.Models;
using Xamarin.Forms;

namespace MaderaDevisBuilder.ViewModels
{
    public partial class DevisPage : ContentPage
    {
        public Projet MonProjet { get; set; }
        public List<Client> Clients { get; set; } = ClientDao.Clients;
        public List<Module> Modules { get; set; } = ModuleDao.Modules;
        public ObservableCollection<Produit> Produits { get; set; } = new ObservableCollection<Produit>();
        public List<string> Gammes { get; set; } = new List<string>
        {
            "Vert",
            "Luxe"
        };

        public DevisPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public void enableProjectName(object sender,EventArgs e)
        {
            ProjectName.IsEnabled = true;
            MonProjet = new Projet(ProjectName.Text); //A cause de l'event unfocused ou completed, entry n'a pas reelement de valeur au moment de l'evenement i.e -> recuperer la valeur d'une autre maniere pour fix le bug de projet qui n'est pas reelement instancié
            CreaMod.IsEnabled = true;
        }

        public void enableGamme(object sender, EventArgs e)
        {
            GammeList.IsEnabled = true;
        }

        public void enableModule(object sender, EventArgs e)
        {
            ModuleList.IsEnabled = true;
        }

        public void enableButton(object sender, EventArgs e)
        {
            AddButton.IsEnabled = true;
        }

        public void addProduit(object sender, EventArgs e)
        {
            Produits.Add(new Produit((string)GammeList.SelectedItem, (Module)ModuleList.SelectedItem));
            
            GammeList.SelectedItem = null;
            ModuleList.SelectedItem = null;

            ModuleList.IsEnabled = false;
            AddButton.IsEnabled = false;
        }

        public void setModuleList(Module m)
        {
            ModuleList.SelectedItem = m;
        }

        public void goCreateMod(object sender, EventArgs e)
        {
            Navigation.PushAsync(new CreateModule(this));
        }

        public void deleteProduit(object sender, EventArgs e)
        {
            var frameSender = (Frame)sender;
            var par = (Produit)frameSender.BindingContext;

            GammeList.SelectedItem = par.Gamme;
            ModuleList.SelectedItem = par.Module;
            GammeList.IsEnabled = true;
            ModuleList.IsEnabled = true;
            AddButton.IsEnabled = true;

            Produits.Remove(par);
        }
    }
}
