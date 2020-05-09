using System;
namespace MaderaDevisBuilder.Models
{
    public class Mesure
    {
        float section;
        float longueur;
        string angle;

        public Mesure(float section, float longueur)
        {
            Section = section;
            Longueur = longueur;
        }

        public Mesure(float section, float longueur, string angle)
        {
            Section = section;
            Longueur = longueur;
            Angle = angle;
        }

        public float Section { get => section; set => section = value; }
        public float Longueur { get => longueur; set => longueur = value; }
        public string Angle { get => angle; set => angle = value; }
    }
}
