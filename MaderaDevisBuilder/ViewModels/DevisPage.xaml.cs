using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MaderaDevisBuilder.DAO;
using MaderaDevisBuilder.Models;
using Xamarin.Forms;
using System.Linq;

namespace MaderaDevisBuilder.ViewModels
{
    public partial class DevisPage : ContentPage
    {
        public Projet MonProjet { get; set; }
        public List<Client> Clients { get; set; } = ClientDao.Clients;
        public ObservableCollection<Module> Modules { get; set; } = new ObservableCollection<Module>(ModuleDao.Modules);
        public ObservableCollection<Produit> Produits { get; set; } = new ObservableCollection<Produit>();
        public List<Gamme> Gammes { get; set; } = GammeDao.Gammes;

        public DevisPage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        public void enableProjectName(object sender,EventArgs e)
        {
            ProjectName.IsEnabled = true;
        }

        public void enableGamme(object sender, EventArgs e)
        {
            MonProjet = new Projet(ProjectName.Text, (Client)ClientList.SelectedItem);
            GammeList.IsEnabled = true;
            CreaMod.IsEnabled = true;
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
            Produit p = new Produit((Gamme)GammeList.SelectedItem, (Module)ModuleList.SelectedItem);
            bool conf = false;
            foreach(Produit pl in Produits)
            {
                if (p.Nom == pl.Nom && p.Gamme.Nom == pl.Gamme.Nom)
                {
                    pl.addQte();
                    conf = true;
                    break;
                }
            }
            if (!conf)
            {
                Produits.Add(p);
            }
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

        public void createProjet(object sender, EventArgs e)
        {
            MonProjet.Produits = Produits.ToList();
            Navigation.PushAsync(new PortailProjet(MonProjet));
        }
    }
}
