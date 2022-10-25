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
    public partial class Resultat : UserControl
    {
        /// <summary>
        /// Connecter le manager de App à la page Resultat.xaml
        /// </summary>
        public Manager Manager => (App.Current as App).LeManager;
        /// <summary>
        /// Initialise la page Résultat
        /// </summary>
        public Resultat()
        {
            InitializeComponent();
            DataContext = Manager;

        }
        /// <summary>
        /// Fonction pour utiliser le bouton Retour Page Analyse et reinitialise la liste AliChoisi et SportChoisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetourAliment(object sender, RoutedEventArgs e)
        {
            Manager.ViderSelection();
            Page.Content = new Aliment();
        }
        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
        /// <summary>
        /// Fonction pour utiliser le bouton Retour Page d'Acceuil et reinitialise la liste AliChoisi et SportChoisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Acceuil(object sender, RoutedEventArgs e)
        {
            Manager.ViderSelection();
            Page.Content = new Main();
        }
        /// <summary>
        /// Fonction pour utiliser le bouton Analyse de votre alimentation et reinitialise la liste AliChoisi et SportChoisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetourAnalyse(object sender, RoutedEventArgs e)
        {
            Manager.ViderSelection();
            Page.Content = new Analyse();
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {

        }
    }
}
