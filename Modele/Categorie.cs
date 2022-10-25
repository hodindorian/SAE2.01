using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleV2
{
    /// <summary>
    /// Permet de créer une classe qui stocke les noms de catégories de notre application
    /// </summary>
    public class Categorie
    {
        public Categorie(string categoName)
        {
            CategoName = categoName;
        }
        public string CategoName
        {
            get;
            private set;
        }
    }
}
