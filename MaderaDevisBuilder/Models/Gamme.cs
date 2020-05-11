namespace MaderaDevisBuilder.Models
{
    public class Gamme
    {
        string nom;
        float multiplier;

        public Gamme(string nom, float multiplier)
        {
            Nom = nom;
            Multiplier = multiplier;
        }

        public string Nom { get => nom; set => nom = value; }
        public float Multiplier { get => multiplier; set => multiplier = value; }
    }
}