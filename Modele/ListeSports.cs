using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleV2
{
    /// <summary>
    /// Permet de créer une liste de différent sport que l'utilisateur peut selectionner
    /// </summary>
    public class ListeSports
    {
        public ListeSports(List<Sport> spo)
        {
            Spo = spo;
        }
        public ListeSports()
        {
            Spo = new List<Sport>();
        }
        public List<Sport> Spo
        {
            get;
            private set;
        }
        public void affichSport()
        {
            foreach (Sport s in Spo)
            {
                Console.WriteLine(s.CaloriesPerdu);
            }
        }
        public void ChargeSports()
        {
            Spo.Add(new Sport("Sprint", 1240));
            Spo.Add(new Sport("Ping pong", 750));
            Spo.Add(new Sport("Natation", 680));
            Spo.Add(new Sport("Football", 550));
            Spo.Add(new Sport("Marathon", 930));
            Spo.Add(new Sport("Cyclisme", 420));
            Spo.Add(new Sport("Gymnastique", 280));
            Spo.Add(new CoursePied("Marathon", 320, 5));
        }
    }
}
