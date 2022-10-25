using ModeleV2;
using System;
using Xunit;

namespace TestManager
{
    public class testSport
    {
        [Theory]
        [InlineData(11)]
        [InlineData(13)]
        public void testSports(float Calo)
        {
            Sport s = new Sport("Football", Calo);
            Assert.Equal(Calo, s.CaloriesPerdu);
            Assert.Equal("Football", s.Nom);
        }
    }
}
