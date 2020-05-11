namespace MaderaDevisBuilder.Models
{
    
    public class Module
    {
        private string nom;
        private Mesure[] mesures;
        string showmesure = "";

        public Module(string nom, Mesure[] mesures)
        {
            Nom = nom;
            Mesures = mesures;
            foreach(Mesure r in mesures)
            {
                showmesure += "S=" + r.Section + " L=" + r.Longueur + " ";
                if(r.Angle != null)
                {
                    showmesure += "A=" + r.Angle + " ";
                }
            }
        }

        public string Nom { get => nom; set => nom = value; }
        public Mesure[] Mesures { get => mesures; set => mesures = value; }
        public string Showmesure { get => showmesure; set => showmesure = value; }
    }
}