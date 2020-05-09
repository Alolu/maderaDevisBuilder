namespace MaderaDevisBuilder.Models
{
    
    public class Module
    {
        private string nom;
        private Mesure[] mesures;

        public Module(string nom, Mesure[] mesures)
        {
            Nom = nom;
            Mesures = mesures;
        }

        public string Nom { get => nom; set => nom = value; }
        public Mesure[] Mesures { get => mesures; set => mesures = value; }
    }
}