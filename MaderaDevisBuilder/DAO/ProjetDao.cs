using System;
using System.Collections.Generic;
using MaderaDevisBuilder.Models;

namespace MaderaDevisBuilder.DAO
{
    public class ProjetDAO
    {
        private static List<Client> Clients = ClientDao.Clients;
        private static List<Produit> Produits = ProduitDao.Produits;

        public List<Projet> Projets { get; set; } = new List<Projet>
            {
                new Projet("Borniche-01","BL1-01",Clients[0],new DateTime(),Produits)
            };
    }
}
