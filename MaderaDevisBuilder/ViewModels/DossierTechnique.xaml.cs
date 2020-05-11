using System;
using System.Collections.Generic;
using MaderaDevisBuilder.Models;
using Xamarin.Forms;

namespace MaderaDevisBuilder.ViewModels
{
    public partial class DossierTechnique : ContentPage
    {
        public Projet projet { get; set; }

        public DossierTechnique(Projet projet)
        {
            this.projet = projet;
            NavigationPage.SetHasNavigationBar(this, false);
            NavigationPage.SetHasBackButton(this, false);
            InitializeComponent();
            BindingContext = this;
        }
    }
}
