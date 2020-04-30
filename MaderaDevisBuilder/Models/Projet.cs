using System;
using System.Collections.Generic;

namespace MaderaDevisBuilder.Models
{
    public class Projet
    {

        string nom;
        string reference;
        Client client;
        DateTime date;
        List<Produit> produits;

        public Projet(string nom, string reference, Client client, DateTime date, List<Produit> produits)
        {
            Nom = nom;
            Reference = reference;
            Client = client;
            Date = date;
            Produits = produits;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Reference { get => reference; set => reference = value; }
        public Client Client { get => client; set => client = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<Produit> Produits { get => produits; set => produits = value; }
    }
}
