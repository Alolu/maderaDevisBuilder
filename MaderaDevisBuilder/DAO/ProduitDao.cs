using System;
using System.Collections.Generic;
using MaderaDevisBuilder.Models;

namespace MaderaDevisBuilder.DAO
{
    public class ProduitDao
    {
        private static List<Module> Modules = ModuleDao.Modules;

        public static List<Produit> Produits { get; set; } = new List<Produit>
            {
                new Produit(0,"Luxe",Modules[0]),
                new Produit(1,"Luxe",Modules[1]),
                new Produit(2,"Luxe",Modules[2]),
                new Produit(3,"Luxe",Modules[3]),
                new Produit(4,"Imperial",Modules[0]),
                new Produit(5,"Imperial",Modules[1]),
                new Produit(6,"Imperial",Modules[2]),
                new Produit(7,"Imperial",Modules[3])
            };
    }
}
