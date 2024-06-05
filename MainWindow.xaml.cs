using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using static System.Net.Mime.MediaTypeNames;

namespace SAE_201_MARATHON
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }
        /*    --------------------    BUTTONS      -------------------      */

        private void Button_Connexion(object sender, RoutedEventArgs e)
        {
            const string correctUsername = "imdapi";
            const string correctPassword = "password123";


            string login = tbLogin.Text;
            string motDePasse = pswrdBox.Password;

            if (login == correctUsername && motDePasse == correctPassword)
            {
                stackPanelConnexion.Visibility = Visibility.Hidden;
                RechercheCourse.Visibility = Visibility.Visible;

                lbConnexion.Visibility = Visibility.Visible;
                labelRechercheCourse.Visibility = Visibility.Visible;
                labelSelectionCoureurs.Visibility = Visibility.Visible;

                lbConnexion.Background = Brushes.LawnGreen;
                lbConnexion.TextDecorations = null;
                labelSelectionCoureurs.Background = Brushes.LawnGreen;
                labelSelectionCoureurs.TextDecorations = null;

                labelRechercheCourse.Background = Brushes.GreenYellow;
                labelRechercheCourse.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Suivant_1(object sender, RoutedEventArgs e)
        {
            RechercheCourse.Visibility = Visibility.Hidden;
            RechercheCoureurs.Visibility = Visibility.Visible;
            imgCourse.Visibility = Visibility.Hidden;

            labelSelectionCoureurs.Background = Brushes.GreenYellow;
            labelSelectionCoureurs.TextDecorations = TextDecorations.Underline;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;
            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LawnGreen;
        }

        private void Button_Suivant_2(object sender, RoutedEventArgs e)
        {
            RechercheCoureurs.Visibility = Visibility.Hidden;
            SelectionCoureurs.Visibility = Visibility.Visible;
        }

        private void Button_Precedent_1(object sender, RoutedEventArgs e)
        {
            RechercheCourse.Visibility = Visibility.Visible;
            RechercheCoureurs.Visibility = Visibility.Hidden;
            imgCourse.Visibility = Visibility.Visible;

            labelRechercheCourse.Background = Brushes.GreenYellow;
            labelRechercheCourse.TextDecorations = TextDecorations.Underline;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;
            labelSelectionCoureurs.TextDecorations = null;
            labelSelectionCoureurs.Background = Brushes.LawnGreen;
        }

        private void Button_Precedent_2(object sender, RoutedEventArgs e)
        {
            RechercheCoureurs.Visibility = Visibility.Visible;
            SelectionCoureurs.Visibility = Visibility.Hidden;
        }
        private void Button_Suivant_3(object sender, RoutedEventArgs e)
        {
            SelectionCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Visible;
        }

        private void Button_Confirmer(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Merci d'avoir confirmé", "Confirmation",
            MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void Button_Precedent_3(object sender, RoutedEventArgs e)
        {
            SelectionCoureurs.Visibility = Visibility.Visible;
            ConfirmationInscription.Visibility = Visibility.Hidden;
        }

        private void Button_Deconnexion(object sender, RoutedEventArgs e)
        {
            stackPanelConnexion.Visibility= Visibility.Visible;
            RechercheCourse.Visibility= Visibility.Hidden;

            lbConnexion.Background = Brushes.GreenYellow;
            lbConnexion.TextDecorations = TextDecorations.Underline;

            labelRechercheCourse.Background = Brushes.LawnGreen;
            labelRechercheCourse.TextDecorations = null;
            labelSelectionCoureurs.TextDecorations = null;
            labelSelectionCoureurs.Background = Brushes.LawnGreen;
        }

        /*    --------------------    LABELS      -------------------      */
        private void connexionLabelClick (object sender, MouseButtonEventArgs e) 
        {
            stackPanelConnexion.Visibility = Visibility.Visible;

            RechercheCourse.Visibility = Visibility.Hidden;
            RechercheCoureurs.Visibility= Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            SelectionCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            imgCourse.Visibility = Visibility.Visible;

            lbConnexion.Background = Brushes.GreenYellow;
            lbConnexion.TextDecorations = TextDecorations.Underline;

            labelRechercheCourse.Visibility = Visibility.Hidden;
            labelSelectionCoureurs.Visibility = Visibility.Hidden;

            labelRechercheCourse.Background = Brushes.LawnGreen;
            labelRechercheCourse.TextDecorations = null;
            labelSelectionCoureurs.TextDecorations = null;
            labelSelectionCoureurs.Background = Brushes.LawnGreen;
        }
        private void rechercherCourseLabelClick(object sender, MouseButtonEventArgs e)
        {
            RechercheCourse.Visibility = Visibility.Visible;
            
            stackPanelConnexion.Visibility = Visibility.Hidden;
            RechercheCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            SelectionCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            imgCourse.Visibility = Visibility.Visible;

            labelRechercheCourse.Background = Brushes.GreenYellow;
            labelRechercheCourse.TextDecorations = TextDecorations.Underline;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;
            labelSelectionCoureurs.TextDecorations = null;
            labelSelectionCoureurs.Background = Brushes.LawnGreen;

        }

        private void selectionCoureursLabelClick(object sender, MouseButtonEventArgs e)
        {
            SelectionCoureurs.Visibility = Visibility.Visible;
            
            RechercheCourse.Visibility = Visibility.Hidden;
            stackPanelConnexion.Visibility = Visibility.Hidden;
            RechercheCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            imgCourse.Visibility = Visibility.Hidden;

            labelSelectionCoureurs.Background = Brushes.GreenYellow;
            labelSelectionCoureurs.TextDecorations = TextDecorations.Underline;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;
            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LawnGreen;
        }
        private void controlLabels()
        {
            if (stackPanelConnexion.Visibility == Visibility.Visible)
            {
                lbConnexion.Visibility = Visibility.Hidden;
                labelRechercheCourse.Visibility = Visibility.Hidden;
                labelSelectionCoureurs.Visibility = Visibility.Hidden;
            }
        }




    }
    

    
}
