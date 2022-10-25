using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleV2
{
    /// <summary>
    /// Classe enum des différentes vitamines qui existent
    /// </summary>
    public enum Vitamines : byte
    {
        A,
        B1,
        B2,
        B3,
        B5,
        B6,
        B8,
        B9,
        B12,
        C,
        D,
        E,
        K
    }
    /// <summary>
    /// Classe qui permet de rentrer les différentes données 
    /// </summary>
    public class Aliment
    {
        public Aliment(string nom, float glucides, float lipides, float proteines, float calories, Categorie typeAli, string origines, List<string> exportateurs, List<Vitamines> vit, float prix, string image,string texte)
        {
            Nom = nom;
            Glucides = glucides;
            Lipides = lipides;
            Proteines = proteines;
            Calories = calories;
            TypeAli = typeAli;
            Exportateurs = exportateurs;
            Vit = vit;
            Origines = origines;
            Prix = prix;
            Image = image;
            Texte = texte;
        }

        public string Nom {get; set;}
        public float Glucides {get; private set;}
        public float Lipides {get; private set;}
        public float Proteines {get; private set;}
        public float Calories {get; private set;}
        public Categorie TypeAli { get; private set; }
        public List<string> Exportateurs {get; private set;}
        public string Origines {get; private set;}
        public List<Vitamines> Vit {get; private set;}
        public float Prix {get; private set;}
        public string Image { get; set; }
        public string Texte { get; set; }

        public void afficherExportateurs(){
            foreach(string s in Exportateurs)
            {
                Console.WriteLine(s);
            }
        }
        public void afficherVitamines(){
            foreach (Vitamines s in Vit)
            {
                Console.WriteLine(s);
            }
        }

    }
}
