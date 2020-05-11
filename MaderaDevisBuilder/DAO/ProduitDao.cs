using System;
using System.Collections.Generic;
using MaderaDevisBuilder.Models;

namespace MaderaDevisBuilder.DAO
{
    public class ProduitDao
    {
        private static List<Module> Modules = ModuleDao.Modules;
        private static List<Gamme> Gammes = GammeDao.Gammes;

        public static List<Produit> Produits { get; set; } = new List<Produit>
            {
                new Produit(0,Gammes[0],Modules[0]),
                new Produit(1,Gammes[0],Modules[1]),
                new Produit(2,Gammes[0],Modules[2]),
                new Produit(3,Gammes[0],Modules[3]),
                new Produit(4,Gammes[0],Modules[0]),
                new Produit(5,Gammes[0],Modules[1]),
                new Produit(6,Gammes[0],Modules[2]),
                new Produit(7,Gammes[0],Modules[3])
            };
    }
}
