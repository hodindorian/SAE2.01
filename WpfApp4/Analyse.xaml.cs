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
    public partial class Analyse : UserControl
    {
        /// <summary>
        /// Connecter le manager de App à la page Analyse.xaml
        /// </summary>
        public Manager Manager => (App.Current as App).LeManager;
        /// <summary>
        /// Initialise la page Analyse
        /// </summary>
        public Analyse()
        {
            InitializeComponent();
            DataContext = Manager;
        }
        /// <summary>
        /// Remplit la liste AliChoisit avec les données remplit par l'utilisateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Calcul(object sender, RoutedEventArgs e)
        {
            Manager.AliChoisit.Add((ModeleV2.Aliment)Entree1.SelectedValue);
            Manager.AliChoisit.Add((ModeleV2.Aliment)Entree2.SelectedValue);
            Manager.AliChoisit.Add((ModeleV2.Aliment)Entree3.SelectedValue);
            Manager.AliChoisit.Add((ModeleV2.Aliment)Entree4.SelectedValue);
            Manager.AliChoisit.Add((ModeleV2.Aliment)Entree5.SelectedValue);
            Manager.AliChoisit.Add((ModeleV2.Aliment)Entree6.SelectedValue);
            Manager.calculCalories();
            Manager.calculGlucides();
            Manager.calculLipides();
            ///Manager.SportChoisit.Add((ModeleV2.Sport)Sport1.SelectedValue, (int)Sport1Temps.SelectedValue);
            ///Manager.SportChoisit.Add((ModeleV2.Sport)Sport2.SelectedValue, (int)Sport2Temps.SelectedValue);

            Page.Content = new Resultat();
        }
        /// <summary>
        /// Fonction pour utiliser le bouton Retour Liste Aliments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
