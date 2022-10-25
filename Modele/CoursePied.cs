using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleV2
{
    /// <summary>
    /// Pour permettre d'avoir différentes intensité pour la course à pied
    /// </summary>
    public class CoursePied : Sport
    {
        public CoursePied(string nom, float caloriesPerdu,int vitesse) : base(nom, caloriesPerdu)
        {
            Vitesse = vitesse;
        }
        public int Vitesse
        {
            get;
            private set;
        }
    }
}
