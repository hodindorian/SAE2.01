using ModeleV2;
using System;
using System.Collections.Generic;
using Xunit;

namespace TestManager
{
    public class testManager
    {
        [Fact]
        public void TestsManager()
        {
            Manager m1 = new Manager();
            m1.ChargeDonnees();
            Assert.Equal(0, m1.Calories);
            Assert.Equal(0, m1.Glucides);
            Assert.Equal(0, m1.Lipides);

            Categorie c = new Categorie("Fruit");
            List<Vitamines> v3 = new List<Vitamines>();
            v3.Add(Vitamines.B1);
            v3.Add(Vitamines.B3);
            v3.Add(Vitamines.C);
            Aliment a1 = new Aliment("Framboise", 10, 6, 4, 7, c, "Asie centrale", new List<string>() { "Turquie", "Ouzbekistan", "Iran" }, v3, 2, "/Images/abricot.png", "L'abricot est le fruit d'un arbre généralement de petite taille appelé abricotier, de la famille des Rosaceae. Le nom scientifique de l'abricotier est Prunus armeniaca (prune d'Arménie). Il appartient au sous-genre des Prunus, section Armeniaca avec les quatre autres abricotiers du monde. ");
            Aliment a2 = new Aliment("Raisins", 8, 5, 3, 9, c, "Europe de l'ouest", new List<string>() { "Italie", "chine", "Espagne" }, v3, 2, "/Images/abricot.png", "L'abricot est le fruit d'un arbre généralement de petite taille appelé abricotier, de la famille des Rosaceae. Le nom scientifique de l'abricotier est Prunus armeniaca (prune d'Arménie). Il appartient au sous-genre des Prunus, section Armeniaca avec les quatre autres abricotiers du monde. ");
            m1.ajouterAliment(a1);
            m1.ajouterAliment(a2);

            float Res = m1.calculGlucides();
            Assert.Equal(18, Res);
            Res = m1.calculLipides();
            Assert.Equal(11, Res);
            Res = m1.calculProteines();
            Assert.Equal(7, Res);

            Sport s1 = new Sport("Football", 4);
            m1.ajouterSport(s1,2);
            Res = m1.calculCalories();
            Assert.Equal(8, Res);

            m1.supprimerAliment(m1.AliChoisit[0]);
            Res = m1.calculGlucides();
            Assert.Equal(8, Res);
            Res = m1.calculCalories();
            Assert.Equal(1, Res);

            m1.ViderSelection();
            Res = m1.calculLipides();
            Assert.Equal(0, Res);

        }
    }
}
