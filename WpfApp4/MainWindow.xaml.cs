using ModeleV2;
using System;
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
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Connecter le manager de App à la page MainWindow.xaml
        /// </summary>
        public Manager LiMa => (App.Current as App).LeManager;


        public MainWindow()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Fonction pour utiliser le bouton Liste des aliments
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Ali.Content = new Aliment();
        }
        /// <summary>
        /// Fonction pour utiliser le bouton Analyse de votre alimentation
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ali.Content = new Analyse();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
        }
    }
}
