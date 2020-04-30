using System;
using System.Collections.Generic;
using MaderaDevisBuilder.Models;

namespace MaderaDevisBuilder.DAO
{
    public class ClientDao
    {
        public static List<Client> Clients { get; set; } = new List<Client>
            {
                new Client(0,"Borniche","Léo","8 rue Brevant"),
                new Client(1,"Dupire","Jérome","9 rue Brevant"),
                new Client(2,"Merle","Vanessa","10 rue Brevant"),
                new Client(3,"Planchon","Alexis","11 rue Brevant"),
                new Client(4,"Bouchez","Romain","12 rue Brevant"),
                new Client(5,"De Lima","Ambroise","13 rue Brevant")
            };
    }
}
