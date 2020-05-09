using System;
using System.Collections.Generic;
using MaderaDevisBuilder.Models;

namespace MaderaDevisBuilder.DAO
{
    public class ModuleDao
    {
        public static Mesure[] m1 = { new Mesure(1, 1) };
        public static Mesure[] m2 = { new Mesure(3, 3,"sortant"), new Mesure(1, 1) };

        public static List<Module> Modules { get; set; } = new List<Module>
            {
                new Module("Mur court avec angle",m1),
                new Module("Mur court droit droit",m1),
                new Module("Mur long droit droit",m2),
                new Module("Mur long avec angle",m2)
            };
    }
}
