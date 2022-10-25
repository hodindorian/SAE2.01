using ModeleV2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeleV2
{
    /// <summary>
    /// Permet de rassembler toutes les données des classes et d'organiser les données qui seront ensuite utilisées sur le XAML
    /// </summary>
    public partial class Manager : INotifyPropertyChanged
    {

        public Manager(List<Aliment> ali, List<Categorie> cat, List<Sport> spo)
        {
            Ali = ali;
            Cat = cat;
            Spo = spo;
            AliChoisit = new List<Aliment>();
            SportChoisit = new Dictionary<Sport, int>();
            Calories = 0;
            Lipides = 0;
            Glucides = 0;

        }
        public Manager()
        {
            Ali = new List<Aliment>();
            Cat = new List<Categorie>();
            Spo = new List<Sport>();
            AliChoisit = new List<Aliment>();
            SportChoisit = new Dictionary<Sport, int>();
            Calories = 0;
            Lipides = 0;
            Glucides = 0;
        }
        public List<Aliment> Ali { get; private set; }
        public List<Categorie> Cat { get; private set; }
        public List<Aliment> AliChoisit { get; private set; }
        public Dictionary<Sport, int> SportChoisit { get; private set; }

        public float Glucides { get; private set; }
        public float Lipides { get; private set; }
        public float Calories { get; private set; }

        public List<Sport> Spo { get; private set; }
        public Aliment AlimentChoisit { 
            get => alimentChoisit; 
            set
            {
                alimentChoisit = value;
                OnPropertyChanged(nameof(AlimentChoisit));
            }
        }
        private Aliment alimentChoisit;

        public event PropertyChangedEventHandler PropertyChanged;

        void OnPropertyChanged(string propertyName)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        public void affichAliments()
        {
            foreach (Aliment s in Ali)
            {
                Console.WriteLine(s.Nom);
            }
        }
        public void affichSport()
        {
            foreach (Sport s in Spo)
            {
                Console.WriteLine(s.CaloriesPerdu);
            }
        }

        public void ChargeDonnees()
        {
            List<string> q1 = new List<string>();
            q1.Add("Canada");
            q1.Add("Pologne");
            q1.Add("Chine");
            List<string> q2 = new List<string>();
            q2.Add("USA");
            q2.Add("Canada");
            List<string> q3 = new List<string>();
            q3.Add("France");
            List<string> q4 = new List<string>() { "Autriche"};
            q4.Add("Espagne");
            q4.Add("Italie");
            q4.Add("Uruguay");
            List<Vitamines> v1 = new List<Vitamines>();
            v1.Add(Vitamines.A);
            List<Vitamines> v2 = new List<Vitamines>();
            List<Vitamines> v3 = new List<Vitamines>();
            v3.Add(Vitamines.B1);
            v3.Add(Vitamines.B3);
            v3.Add(Vitamines.C);
            Cat.Add(new Categorie("Fruits"));
            Cat.Add(new Categorie("Légumes"));
            Cat.Add(new Categorie("Viandes"));
            Cat.Add(new Categorie("Poissons"));
            Cat.Add(new Categorie("Fromages"));
            Cat.Add(new Categorie("Desserts"));
            Ali.Add(new Aliment("Abricot", 11, 4, 14, 48, Cat[0], "Asie centrale", new List<string>() { "Turquie","Ouzbekistan","Iran" }, v3, 2, "/Images/abricot.png", "L'abricot est le fruit d'un arbre généralement de petite taille appelé abricotier, de la famille des Rosaceae. Le nom scientifique de l'abricotier est Prunus armeniaca (prune d'Arménie). Il appartient au sous-genre des Prunus, section Armeniaca avec les quatre autres abricotiers du monde. "));
            Ali.Add(new Aliment("Ananas", 13, 1, 5, 50, Cat[0], "Caraibes", new List<string>() { "Philippines", "Thailandes", "Costa Rica" }, v3, 5, "/Images/ananas.png", "L'ananas (Ananas comosus) est une espèce de plantes xérophytes, originaire d'Amérique du Sud, plus spécifiquement du Paraguay, du nord-est de l'Argentine et sud du Brésil. Il est connu principalement pour son fruit comestible, qui est en réalité un fruit composé. "));
            Ali.Add(new Aliment("Banane", 23, 3, 11, 89, Cat[0], "Afrique", new List<string>() {"Equateur","costa rica"}, v2, 10, "/Images/banane.png", "La banane est le fruit ou la baie dérivant de l’inflorescence du bananier. Les bananes sont des fruits très généralement stériles issus de variétés domestiquées. Seuls les fruits des bananiers sauvages et de quelques cultivars domestiques contiennent des graines. Les bananes sont généralement jaunes avec des taches brunâtres lorsqu'elles sont mûres et vertes quand elles ne le sont pas. "));
            Ali.Add(new Aliment("Cerise", 12, 3, 10, 50, Cat[0], "Asie centrale", new List<string>() { "turquie", "USA", "Ouzbekistan" }, v1, 20, "/Images/cerise.png", "La cerise est le fruit comestible du cerisier. Il s'agit d'une drupe (fruit charnu à noyau), de forme sphérique, de couleur généralement rouge plus ou moins foncé jusque noire, plus rarement jaune. Ce petit fruit compte environ 50 calories pour 100 grammes. La fleur est généralement blanche. "));
            Ali.Add(new Aliment("Kiwana", 8, 13, 18, 44, Cat[0], "afrique", new List<string>() { "Chilie" }, v1, 10, "/Images/kiwana.png", "Son fruit, le kiwano est comestible. Il est également appelé métulon, melano, concombre cornu d'Afrique ou encore melon à corne. En Guadeloupe il est appelé paroka. "));
            Ali.Add(new Aliment("Kiwi", 15, 5, 11, 61, Cat[0], "Chine", new List<string>() { "Chine", "Italie", "Nouvelle-zelande" }, v2, 15, "/Images/kiwi.png", "Les kiwis sont des fruits de plusieurs espèces de lianes du genre Actinidia, famille des Actinidiaceae. Ils sont originaires de Chine1,2, notamment de la province de Shaanxi. On en trouve par ailleurs dans des climats dits montagnards tropicaux. En France, les kiwis de l'Adour sont les seuls à disposer d'une indication géographique protégée (IGP)2 et d'un label rouge. "));
            Ali.Add(new Aliment("Melon", 8, 2, 8, 34, Cat[0], "Egypte", new List<string>() { "Chine", "Turquie", "Iran" }, v1, 3, "/Images/melon.png", "Le melon (Cucumis melo) est une plante herbacée annuelle originaire d'Afrique intertropicale, appartenant à la famille des Cucurbitacées et largement cultivée comme plante potagère pour son fruit comestible. La tige n'est pas volubile mais la plante peut grimper en s'accrochant à des supports grâce à des vrilles simples."));
            Ali.Add(new Aliment("Noix de coco", 15, 330, 34, 354, Cat[0], "Polynesie", new List<string>() { "Indonesie", "Sri lanka", "Thailande" }, v1, 10, "/Images/noixcoco.png", "La noix de coco est le fruit (drupe) du cocotier (Cocos nucifera), un des représentants de la famille des palmiers ou Arécacées. L'inflorescence complète peut atteindre 1 mètre de long. "));
            Ali.Add(new Aliment("Orange", 12, 1, 9, 47, Cat[0], "Chine", new List<string>() { "Bresil", "Chine", "Inde" }, v2, 4, "/Images/orange.png", "L’orange ou orange douce est le fruit de l'oranger (Citrus sinensis L.) de la famille des Rutacées. Comme pour tous les agrumes, il s'agit d'une forme particulière de baie appelée hespéride. Il existe plusieurs variétés d’oranges, classées en quatre groupes variétaux. "));
            Ali.Add(new Aliment("Pastèque", 8, 2, 6, 30, Cat[0], "Lybie", new List<string>() { "Chine", "Iran", "Turquie" }, v3, 5, "/Images/pasteque.png", "La pastèque (Citrullus lanatus (Thunb.) Matsum. & Nakai, 1916), aussi appelée melon d'eau, est une espèce de plantes herbacées de la famille des Cucurbitacées, originaire d'Afrique de l'Ouest1, largement cultivée pour ses gros fruits lisses, à chair rouge, jaune, verdâtre ou blanche et à graines noires ou rouges. Le terme désigne également ce fruit. Le fruit pèse généralement, à maturité, entre 2 et 5 kg. "));
            Ali.Add(new Aliment("Poire", 15, 1, 3, 57, Cat[0], "Asie", new List<string>() { "Japon", "Italie"}, v1, 10, "/Images/poire.png", "La poire est le fruit à pépins comestible au goût doux et sucré, produit par le poirier commun (Pyrus communis L.), arbre de la famille des Rosaceae. "));
            Ali.Add(new Aliment("Pomme", 14, 2, 4, 52, Cat[0], "Asie centrale", new List<string>() { "Chine", "USA", "Turquie" }, v2, 5, "/Images/pomme.png", "La pomme est un fruit comestible produit par un pommier. Les pommiers sont cultivés à travers le monde et représentent l'espèce la plus cultivée du genre Malus. L'arbre est originaire d'Asie centrale, où son ancêtre sauvage, le Malus sieversii peut encore être trouvé de nos jours. Les pommes sont cultivées depuis des milliers d'années en Asie et en Europe et ont été importées en Amérique du Nord par les colons européens. Les pommes ont une signification religieuse et mythologique dans de nombreuses cultures, notamment les mythologies nordique et grecque ou la tradition chrétienne d'Europe. "));
            Ali.Add(new Aliment("Poulet", 25, 32, 15, 13, Cat[0], "Asie", q3, v3, 6, "Poulet.jpg",""));
            Ali.Add(new Aliment("Brocoli", 25, 32, 15, 6, Cat[0], "Afrique equatorial", q4, v2, 20, "Brocoli.jpg",""));
            Spo.Add(new Sport("Sprint", 1240));
            Spo.Add(new Sport("Ping pong", 750));
            Spo.Add(new Sport("Natation", 680));
            Spo.Add(new Sport("Football", 550));
            Spo.Add(new Sport("Marathon", 930));
            Spo.Add(new Sport("Cyclisme", 420));
            Spo.Add(new Sport("Gymnastique", 280));
            Spo.Add(new CoursePied("Marathon", 320, 5));
            AlimentChoisit = Ali[0];
        }
    }
}
