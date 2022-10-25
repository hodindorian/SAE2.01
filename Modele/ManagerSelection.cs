using ModeleV2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleV2
{
    /// <summary>
    /// Organise visuelement les données recupérées par la classe Manager
    /// </summary>
    public partial class Manager
    {
        public void afficherAliChoisit()
        {
            foreach (Aliment s in AliChoisit)
            {
                Console.WriteLine(s.Nom);
            }
        }
        public float calculCalories()
        {
            float totaux = 0;
            foreach (Aliment s in AliChoisit)
            {
                totaux = totaux + s.Calories;
            }
            foreach (KeyValuePair<Sport, int> s in SportChoisit)
            {
                totaux = totaux - s.Key.CaloriesPerdu * s.Value;
            }
            Calories = totaux;
            return totaux;
        }
        public float calculProteines()
        {
            float totaux = 0;
            foreach (Aliment s in AliChoisit)
            {
                totaux = totaux + s.Proteines;
            }
            return totaux;
        }
        public float calculGlucides()
        {
            float totaux = 0;
            foreach (Aliment s in AliChoisit)
            {
                totaux = totaux + s.Glucides;
            }
            Glucides = totaux;
            return totaux;
        }
        public float calculLipides()
        {
            float totaux = 0;
            foreach (Aliment s in AliChoisit)
            {
                totaux = totaux + s.Lipides;
            }
            Lipides = totaux;
            return totaux;
        }
        public bool ajouterAliment(Aliment nouveau)
        {
            if (AliChoisit.Contains(nouveau))
            {
                return false;
            }
            AliChoisit.Add(nouveau);
            return true;
        }
        public void ajouterSport(Sport nouveau, int temps)
        {
            SportChoisit.Add(nouveau, temps);
        }
        public bool supprimerAliment(Aliment delete)
        {
            if (AliChoisit.Contains(delete))
            {
                AliChoisit.Remove(delete);
                return true;
            }
            return false;
        }
        public void supprimerSport(Sport delete, int temps)
        {
            SportChoisit.Remove(delete);
        }
        public void ViderSelection()
        {
            AliChoisit.Clear();
            SportChoisit.Clear();
        }


    }
}
