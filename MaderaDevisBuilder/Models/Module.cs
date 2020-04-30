namespace MaderaDevisBuilder.Models
{
    
    public class Module
    {
        private string nom;
        private string type;
        private int section;
        private int longueur;
        private int angleEntrant;
        private int sectionEntrant;
        private int longueurEntrant;
        private int angleSortant;
        private int sectionSortant;
        private int longueurSortant;

        public Module(string nom, string type, int section, int longueur, int angleEntrant, int sectionEntrant, int longueurEntrant, int angleSortant, int sectionSortant, int longueurSortant)
        {
            this.Nom = nom;
            this.Type = type;
            this.Section = section;
            this.Longueur = longueur;
            this.AngleEntrant = angleEntrant;
            this.SectionEntrant = sectionEntrant;
            this.LongueurEntrant = longueurEntrant;
            this.AngleSortant = angleSortant;
            this.SectionSortant = sectionSortant;
            this.LongueurSortant1 = longueurSortant;
        }

        public int LongueurSortant { get => LongueurSortant1; set => LongueurSortant1 = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Type { get => type; set => type = value; }
        public int Section { get => section; set => section = value; }
        public int Longueur { get => longueur; set => longueur = value; }
        public int AngleEntrant { get => angleEntrant; set => angleEntrant = value; }
        public int SectionEntrant { get => sectionEntrant; set => sectionEntrant = value; }
        public int LongueurEntrant { get => longueurEntrant; set => longueurEntrant = value; }
        public int AngleSortant { get => angleSortant; set => angleSortant = value; }
        public int SectionSortant { get => sectionSortant; set => sectionSortant = value; }
        public int LongueurSortant1 { get => longueurSortant; set => longueurSortant = value; }
    }
}