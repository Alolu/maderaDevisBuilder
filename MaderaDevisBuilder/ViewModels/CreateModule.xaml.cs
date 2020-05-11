using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using MaderaDevisBuilder.Models;
using Xamarin.Forms;
using System.Linq;

namespace MaderaDevisBuilder.ViewModels
{
    public partial class CreateModule : ContentPage
    {

        DevisPage page;
        public ObservableCollection<Mesure> Mesures { get; set; } = new ObservableCollection<Mesure>();

        public CreateModule(DevisPage page)
        {
            this.page = page;
            InitializeComponent();
            BindingContext = this;
        }

        public void addMesure(object sender, EventArgs e)
        {
            if (AnglePicker.SelectedIndex == -1) {
                Mesures.Add(new Mesure(float.Parse(SectionEntry.Text), float.Parse(LongueurEntry.Text)));
            } else
            {
                Mesures.Add(new Mesure(float.Parse(SectionEntry.Text), float.Parse(LongueurEntry.Text),(string) AnglePicker.SelectedItem));
            }
            SectionEntry.Text = "";
            LongueurEntry.Text = "";
            AnglePicker.SelectedIndex = -1;
            Confirmer.IsEnabled = true;
        }

        public void addModule(object sender, EventArgs e)
        {
            Module m = new Module(TitreMod.Text, Mesures.ToArray());
            page.Modules.Add(m);
            page.MonProjet.Created.Add(m);
            page.setModuleList(m);
            Navigation.RemovePage(this);
        }
    }
}
