using System;
namespace MaderaDevisBuilder.Models
{
    public class Produit
    {

        int id;
        Gamme gamme;
        Module module;
        string cctp;
        string nom;
        int quantite;
        string calculs;
        float prix = 0;
        float ogprix;
        string calcbackups;

        public Produit(int id, Gamme gamme, Module module)
        {
            this.Id = id;
            this.Gamme = gamme;
            this.Module = module;
        }

        public Produit(Gamme gamme, Module module)
        {
            this.Gamme = gamme;
            this.Module = module;
            this.Nom = gamme.Nom + "-" + module.Nom;
            this.Cctp = Nom + ".pdf";
            this.calculs = gamme.Multiplier.ToString() + "*(";
            this.Quantite = 1;
            foreach (Mesure m in Module.Mesures)
            {
                this.calculs += m.Longueur + "+" + m.Section.ToString();
                this.prix += m.Longueur + m.Section;
                if(m.Angle != null)
                {
                    this.calculs += "+50";
                    this.prix += 50;
                }
                this.calculs += "+";
            }
            prix = prix * gamme.Multiplier;
            this.calculs = this.calculs.TrimEnd('+');
            this.calculs += ")";
            this.calcbackups = calculs;
            this.ogprix = prix;
        }

        public void addQte()
        {
            this.quantite++;
            calculs = quantite.ToString() + "*(" + calcbackups + ")";
            prix += ogprix;
        }

        public int Id { get => id; set => id = value; }
        public Gamme Gamme { get => gamme; set => gamme = value; }
        public Module Module { get => module; set => module = value; }
        public string Cctp { get => cctp; set => cctp = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Calculs { get => calculs; set => calculs = value; }
        public float Prix { get => prix; set => prix = value; }
        public int Quantite { get => quantite; set => quantite = value; }
    }
}
