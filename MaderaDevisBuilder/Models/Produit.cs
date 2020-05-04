using System;
namespace MaderaDevisBuilder.Models
{
    public class Produit
    {

        int id;
        string gamme;
        Module module;

        public Produit(int id, string gamme, Module module)
        {
            this.Id = id;
            this.Gamme = gamme;
            this.Module = module;
        }

        public Produit(string gamme, Module module)
        {
            this.Gamme = gamme;
            this.Module = module;
        }

        public int Id { get => id; set => id = value; }
        public string Gamme { get => gamme; set => gamme = value; }
        public Module Module { get => module; set => module = value; }
    }
}
