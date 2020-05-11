using System;
using System.Collections.Generic;

namespace MaderaDevisBuilder.Models
{
    public class Projet
    {

        string nom;
        string reference;
        Client client;
        DateTime date = new DateTime();
        List<Produit> produits;
        List<Module> created = new List<Module>();

        public Projet(string nom,Client client)
        {
            Nom = nom;
            Client = client;
            Reference = client.Nom + "-" + nom + "-1";
        }

        public Projet(string nom, string reference, Client client, List<Produit> produits)
        {
            Nom = nom;
            Reference = reference;
            Client = client;
            Produits = produits;
        }

        public string Nom { get => nom; set => nom = value; }
        public string Reference { get => reference; set => reference = value; }
        public Client Client { get => client; set => client = value; }
        public DateTime Date { get => date; set => date = value; }
        public List<Produit> Produits { get => produits; set => produits = value; }
        public List<Module> Created { get => created; set => created = value; }
    }
}
