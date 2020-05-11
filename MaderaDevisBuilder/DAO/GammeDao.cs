using System;
using System.Collections.Generic;
using MaderaDevisBuilder.Models;

namespace MaderaDevisBuilder.DAO
{
    public class GammeDao
    {
        public static List<Gamme> Gammes { get; set; } = new List<Gamme>
            {
                new Gamme("Luxe",1.5F),
                new Gamme("Vert",1.2F),
            };
    }
}
