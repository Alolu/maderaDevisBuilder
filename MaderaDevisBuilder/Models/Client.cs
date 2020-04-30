using System;
namespace MaderaDevisBuilder.Models
{
    public class Client
    {
        int id;
        string nom;
        string prenom;
        string adresse;

        public Client(int id, string nom, string prenom, string adresse)
        {
            this.Id = id;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Adresse = adresse;
        }

        public int Id { get => id; set => id = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public string Adresse { get => adresse; set => adresse = value; }
    }
}
