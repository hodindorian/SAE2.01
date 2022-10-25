using System;
using Xunit;
using ModeleV2;
using System.Collections.Generic;

namespace Tests
{
    public class testAliment
    {
        [Theory]
        [InlineData(11,4,14,48)]
        [InlineData(13, 4, 12, 21)]
        public void TestsAliments(float Glu, float Lip, float Pro, float Cal)
        {
            Categorie c = new Categorie("Fruit");
            List<Vitamines> v3 = new List<Vitamines>();
            v3.Add(Vitamines.B1);
            v3.Add(Vitamines.B3);
            v3.Add(Vitamines.C);
            Aliment a1 = new Aliment("Abricot", Glu, Lip, Pro, Cal, c, "Asie centrale", new List<string>() { "Turquie", "Ouzbekistan", "Iran" }, v3, 2, "/Images/abricot.png", "L'abricot est le fruit d'un arbre généralement de petite taille appelé abricotier, de la famille des Rosaceae. Le nom scientifique de l'abricotier est Prunus armeniaca (prune d'Arménie). Il appartient au sous-genre des Prunus, section Armeniaca avec les quatre autres abricotiers du monde. ");
            Assert.Equal(Glu, a1.Glucides);
            Assert.Equal(Lip, a1.Lipides);
            Assert.Equal(Pro, a1.Proteines);
            Assert.Equal(Cal, a1.Calories);
            Assert.Equal(2, a1.Prix);
            Assert.Equal("Abricot", a1.Nom);
            Assert.Equal("Asie centrale", a1.Origines);
            Assert.Equal("Ouzbekistan", a1.Exportateurs[1]);
        }

    }
}
