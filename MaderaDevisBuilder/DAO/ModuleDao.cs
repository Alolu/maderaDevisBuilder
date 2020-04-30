using System;
using System.Collections.Generic;
using MaderaDevisBuilder.Models;

namespace MaderaDevisBuilder.DAO
{
    public class ModuleDao
    {
        public static List<Module> Modules { get; set; } = new List<Module>
            {
                new Module("Mur court avec angle","angle",30,30,30,30,30,30,30,30),
                new Module("Mur court droit droit","droit",30,30,30,30,30,30,30,30),
                new Module("Mur long droit droit","droit",30,30,30,30,30,30,30,30),
                new Module("Mur long avec angle","angle",30,30,30,30,30,30,30,30)
            };
}
}
