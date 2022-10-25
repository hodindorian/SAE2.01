using ModeleV2;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp4;

namespace SAE
{
    /// <summary>
    /// Logique d'interaction pour Aliment.xaml
    /// </summary>
    public partial class Aliment : UserControl
    {
        /// <summary>
        /// Connecter le manager de App à la page Aliment.xaml
        /// </summary>
        public Manager Manager => (App.Current as App).LeManager;

        /// <summary>
        /// Initialise la page Aliment
        /// </summary>
        public Aliment()
        {
            InitializeComponent();
            DataContext = Manager;
        }
        /// <summary>
        /// Les fonctions qui suivent sont reliés à chaque bouton de navigation des différentes catégories
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Fruits(object sender, RoutedEventArgs e)
        {

        }

        private void Legumes(object sender, RoutedEventArgs e)
        {

        }

        private void PL(object sender, RoutedEventArgs e)
        {

        }

        private void Viandes(object sender, RoutedEventArgs e)
        {

        }

        private void Poissons(object sender, RoutedEventArgs e)
        {

        }

        private void Patisserie(object sender, RoutedEventArgs e)
        {

        }
        /// <summary>
        /// Les boutons suivants permettent de naviguer sur les différentes pages d'aliments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Abricot(object sender, RoutedEventArgs e)
        {
            Manager.AlimentChoisit = Manager.Ali[0];
            Page.Content = new Abricot();

        }

        private void Ananas(object sender, RoutedEventArgs e)
        {
            Manager.AlimentChoisit = Manager.Ali[1];
            Page.Content = new Abricot();

        }

        private void Banane(object sender, RoutedEventArgs e)
        {
            Manager.AlimentChoisit = Manager.Ali[2];
            Page.Content = new Abricot();

        }

        private void Cerise(object sender, RoutedEventArgs e)
        {
            Manager.AlimentChoisit = Manager.Ali[3];
            Page.Content = new Abricot();

        }

        private void Kiwana(object sender, RoutedEventArgs e)
        {
            Manager.AlimentChoisit = Manager.Ali[4];
            Page.Content = new Abricot();

        }

        private void Kiwi(object sender, RoutedEventArgs e)
        {
            Manager.AlimentChoisit = Manager.Ali[5];
            Page.Content = new Abricot();

        }

        private void Melon(object sender, RoutedEventArgs e)
        {
            Manager.AlimentChoisit = Manager.Ali[6];
            Page.Content = new Abricot();

        }

        private void NDC(object sender, RoutedEventArgs e)
        {
            Manager.AlimentChoisit = Manager.Ali[7];
            Page.Content = new Abricot();

        }

        private void Orange(object sender, RoutedEventArgs e)
        {
            Manager.AlimentChoisit = Manager.Ali[8];
            Page.Content = new Abricot();

        }

        private void Pasteque(object sender, RoutedEventArgs e)
        {
            Manager.AlimentChoisit = Manager.Ali[9];
            Page.Content = new Abricot();

        }

        private void Poire(object sender, RoutedEventArgs e)
        {
            Manager.AlimentChoisit = Manager.Ali[10];
            Page.Content = new Abricot();

        }

        private void Pomme(object sender, RoutedEventArgs e)
        {
            Manager.AlimentChoisit = Manager.Ali[11];
            Page.Content = new Abricot();

        }
        private void RetourAliment(object sender, RoutedEventArgs e)
        {
            Page.Content = new Aliment();
        }
       
        /// <summary>
        /// Fonction pour utiliser le bouton Retour Page d'Acceuil
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Acceuil(object sender, RoutedEventArgs e)
        {
            Page.Content = new Main();
        }
        /// <summary>
        /// Fonction pour utiliser le bouton Analyse de votre alimentation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetourAnalyse(object sender, RoutedEventArgs e)
        {
            Page.Content = new Analyse();
        }
    }
}
