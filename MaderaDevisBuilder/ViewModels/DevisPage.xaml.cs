using System;
using System.Collections.Generic;
using MaderaDevisBuilder.DAO;
using MaderaDevisBuilder.Models;
using Xamarin.Forms;

namespace MaderaDevisBuilder.ViewModels
{
    public partial class DevisPage : ContentPage
    {

        public List<Client> Clients { get; set; } = ClientDao.Clients;

        public DevisPage()
        {
            InitializeComponent();
            BindingContext = this;
        }
    }
}
