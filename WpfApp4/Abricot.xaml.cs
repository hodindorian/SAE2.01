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
    public partial class Abricot : UserControl
    {
        /// <summary>
        /// Connecter le manager de App à la page MainWindow.xaml
        /// </summary>
        public Manager Manager => (App.Current as App).LeManager;
        /// <summary>
        /// Initialise la page Abricot.xaml
        /// </summary>
        public Abricot()
        {
            InitializeComponent();
            DataContext = Manager;
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

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
