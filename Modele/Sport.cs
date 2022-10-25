using System;

namespace ModeleV2
{
    /// <summary>
    /// Permet de rentrer les informations sur différents sports
    /// </summary>
    public class Sport
    {
        public Sport(string nom,float caloriesPerdu)
        {
            Nom = nom;
            CaloriesPerdu = caloriesPerdu;
        }
        public string Nom
        {
            get;
            private set;
        }
        public float CaloriesPerdu
        {
            get;
            private set;
        }
    }
}
