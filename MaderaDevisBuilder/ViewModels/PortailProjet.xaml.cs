using System;
using System.Collections.Generic;
using MaderaDevisBuilder.Models;
using Xamarin.Forms;

namespace MaderaDevisBuilder.ViewModels
{
    public partial class PortailProjet : ContentPage
    {
        Projet projet;
        public PortailProjet(Projet projet)
        {
            this.projet = projet;
            InitializeComponent();
        }

        public void goToDevis(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DevisFinalPage(projet));
        }

        public void goToDossier(object sender, EventArgs e)
        {
            Navigation.PushAsync(new DossierTechnique(projet));
        }
    }
}
