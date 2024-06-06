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

        public void ButtonConnexion(object sender, RoutedEventArgs e)
        {
            const string phpLogin = "imdapi";
            const string phpMotDePasse = "password123";


            string login = tbLogin.Text;
            string motDePasse = pswrdBox.Password;

            if (login == phpLogin && motDePasse == phpMotDePasse)
            {
                stackPanelConnexion.Visibility = Visibility.Hidden;
                RechercheCourse.Visibility = Visibility.Visible;

                gridCourse.Visibility = Visibility.Visible;

                lbConnexion.Visibility = Visibility.Visible;
                labelRechercheCourse.Visibility = Visibility.Visible;
                labelRechercheCoureurs.Visibility = Visibility.Visible;
                labelSelectionneCoureurs.Visibility = Visibility.Visible;
                labelbMontantTotal.Visibility = Visibility.Visible;

                lbConnexion.Background = Brushes.LawnGreen;
                lbConnexion.TextDecorations = null;
                labelRechercheCoureurs.Background = Brushes.LawnGreen;
                labelRechercheCoureurs.TextDecorations = null;

                labelRechercheCourse.Background = Brushes.GreenYellow;
                labelRechercheCourse.TextDecorations = TextDecorations.Underline;
            }
            else
            {
                MessageBox.Show("Identifiant ou mot de passe incorrect", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        //public void BouttonConnexionEnntrer(object sender, KeyEventArgs e)
        //{
        //    if (e.Key == Key.Enter)
        //    {
        //        butConnexion.RaiseEvent(new RoutedEventArgs(Button.ClickEvent));
        //    }
        //}

        private void Button_Suivant_1(object sender, RoutedEventArgs e)
        {
            RechercheCourse.Visibility = Visibility.Hidden;
            RechercheCoureurs.Visibility = Visibility.Visible;
            ListeRechercheCoureurs.Visibility = Visibility.Visible;

            gridCourse.Visibility = Visibility.Hidden;

            labelRechercheCoureurs.Background = Brushes.GreenYellow;
            labelRechercheCoureurs.TextDecorations = TextDecorations.Underline;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;

            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LawnGreen;

            labelSelectionneCoureurs.TextDecorations = null;
            labelSelectionneCoureurs.Background = Brushes.LawnGreen;
        }

        private void Button_Suivant_2(object sender, RoutedEventArgs e)
        {
            RechercheCoureurs.Visibility = Visibility.Hidden;
            ListeRechercheCoureurs.Visibility = Visibility.Hidden;
            SelectionCoureurs.Visibility = Visibility.Visible;

            labelSelectionneCoureurs.Background = Brushes.GreenYellow;
            labelSelectionneCoureurs.TextDecorations = TextDecorations.Underline;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;

            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LawnGreen;

            labelRechercheCoureurs.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.LawnGreen;
        }

        private void Button_Precedent_1(object sender, RoutedEventArgs e)
        {
            RechercheCourse.Visibility = Visibility.Visible;
            RechercheCoureurs.Visibility = Visibility.Hidden;
            ListeRechercheCoureurs.Visibility = Visibility.Hidden;
            gridCourse.Visibility = Visibility.Visible;

            labelRechercheCourse.Background = Brushes.GreenYellow;
            labelRechercheCourse.TextDecorations = TextDecorations.Underline;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;

            labelRechercheCoureurs.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.GreenYellow;

            labelbMontantTotal.Background = Brushes.LawnGreen;
            labelbMontantTotal.TextDecorations = null;

            labelSelectionneCoureurs.Background = Brushes.LawnGreen;
            labelSelectionneCoureurs.TextDecorations = null;
        }

        private void Button_Precedent_2(object sender, RoutedEventArgs e)
        {
            RechercheCoureurs.Visibility = Visibility.Visible;
            ListeRechercheCoureurs.Visibility = Visibility.Visible;
            SelectionCoureurs.Visibility = Visibility.Hidden;

            labelRechercheCoureurs.Background = Brushes.GreenYellow;
            labelRechercheCoureurs.TextDecorations = TextDecorations.Underline;

            labelSelectionneCoureurs.Background = Brushes.LawnGreen;
            labelSelectionneCoureurs.TextDecorations = null;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;

            labelRechercheCourse.Background = Brushes.LawnGreen;
            labelRechercheCourse.TextDecorations = null;

            labelbMontantTotal.Background = Brushes.LawnGreen;
            labelbMontantTotal.TextDecorations = null;
        }
        private void Button_Suivant_3(object sender, RoutedEventArgs e)
        {
            SelectionCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Visible;

            labelbMontantTotal.Background = Brushes.GreenYellow;
            labelbMontantTotal.TextDecorations = TextDecorations.Underline;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;

            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LawnGreen;

            labelRechercheCoureurs.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.LawnGreen;

            labelSelectionneCoureurs.Background = Brushes.LawnGreen;
            labelSelectionneCoureurs.TextDecorations = null;
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

            labelSelectionneCoureurs.Background = Brushes.GreenYellow;
            labelSelectionneCoureurs.TextDecorations = TextDecorations.Underline;

            labelRechercheCoureurs.Background = Brushes.LawnGreen;
            labelRechercheCoureurs.TextDecorations = null;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;

            labelRechercheCourse.Background = Brushes.LawnGreen;
            labelRechercheCourse.TextDecorations = null;

            labelbMontantTotal.Background = Brushes.LawnGreen;
            labelbMontantTotal.TextDecorations = null;
        }

        private void Button_Deconnexion(object sender, RoutedEventArgs e)
        {
            stackPanelConnexion.Visibility = Visibility.Visible;
            RechercheCourse.Visibility = Visibility.Hidden;

            lbConnexion.Background = Brushes.GreenYellow;
            lbConnexion.TextDecorations = TextDecorations.Underline;

            labelRechercheCourse.Background = Brushes.LawnGreen;
            labelRechercheCourse.TextDecorations = null;

            labelRechercheCoureurs.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.LawnGreen;

            gridCourse.Visibility = Visibility.Hidden;

            tbLogin.Text = string.Empty;
            pswrdBox.Password = string.Empty;

            lbConnexion.Visibility = Visibility.Visible;
            labelRechercheCourse.Visibility = Visibility.Hidden;
            labelRechercheCoureurs.Visibility = Visibility.Hidden;
            labelbMontantTotal.Visibility = Visibility.Hidden;
        }

        /*    --------------------    LABELS      -------------------      */
        private void connexionLabelClick(object sender, MouseButtonEventArgs e)
        {
            stackPanelConnexion.Visibility = Visibility.Visible;

            RechercheCourse.Visibility = Visibility.Hidden;
            RechercheCoureurs.Visibility = Visibility.Hidden;
            ListeRechercheCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            SelectionCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            gridCourse.Visibility = Visibility.Visible;

            lbConnexion.Background = Brushes.GreenYellow;
            lbConnexion.TextDecorations = TextDecorations.Underline;

            labelRechercheCourse.Visibility = Visibility.Hidden;
            labelRechercheCoureurs.Visibility = Visibility.Hidden;
            labelSelectionneCoureurs.Visibility = Visibility.Hidden;
            labelbMontantTotal.Visibility = Visibility.Hidden;

            labelRechercheCourse.Background = Brushes.LawnGreen;
            labelRechercheCourse.TextDecorations = null;

            labelRechercheCoureurs.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.LawnGreen;

            labelSelectionneCoureurs.Background = Brushes.LawnGreen;
            labelSelectionneCoureurs.TextDecorations = null;

            labelbMontantTotal.Background = Brushes.LawnGreen;
            labelbMontantTotal.TextDecorations = null;

            tbLogin.Text = string.Empty;
            pswrdBox.Password = string.Empty;
        }
        private void rechercherCourseLabelClick(object sender, MouseButtonEventArgs e)
        {
            RechercheCourse.Visibility = Visibility.Visible;

            stackPanelConnexion.Visibility = Visibility.Hidden;
            RechercheCoureurs.Visibility = Visibility.Hidden;
            ListeRechercheCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            SelectionCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            gridCourse.Visibility = Visibility.Visible;

            labelRechercheCourse.Background = Brushes.GreenYellow;
            labelRechercheCourse.TextDecorations = TextDecorations.Underline;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;

            labelRechercheCoureurs.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.LawnGreen;

            labelSelectionneCoureurs.Background = Brushes.LawnGreen;
            labelSelectionneCoureurs.TextDecorations = null;

        }

        private void rechercherCoureursLabelClick(object sender, MouseButtonEventArgs e)
        {

            RechercheCoureurs.Visibility = Visibility.Visible;
            ListeRechercheCoureurs.Visibility = Visibility.Visible;

            SelectionCoureurs.Visibility = Visibility.Hidden;
            RechercheCourse.Visibility = Visibility.Hidden;
            stackPanelConnexion.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            gridCourse.Visibility = Visibility.Hidden;

            labelRechercheCoureurs.Background = Brushes.GreenYellow;
            labelRechercheCoureurs.TextDecorations = TextDecorations.Underline;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;

            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LawnGreen;

            labelSelectionneCoureurs.Background = Brushes.LawnGreen;
            labelSelectionneCoureurs.TextDecorations = null;
        }


        private void selectionnerCoureursLabelClick(object sender, MouseButtonEventArgs e)
        {
            SelectionCoureurs.Visibility = Visibility.Visible;

            RechercheCoureurs.Visibility = Visibility.Hidden;
            ListeRechercheCoureurs.Visibility = Visibility.Hidden;
            RechercheCourse.Visibility = Visibility.Hidden;
            stackPanelConnexion.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            gridCourse.Visibility = Visibility.Hidden;

            labelSelectionneCoureurs.Background = Brushes.GreenYellow;
            labelSelectionneCoureurs.TextDecorations = TextDecorations.Underline;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;

            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LawnGreen;

            labelRechercheCoureurs.Background = Brushes.LawnGreen;
            labelRechercheCoureurs.TextDecorations = null;

            labelbMontantTotal.Background = Brushes.LawnGreen;
            labelbMontantTotal.TextDecorations = null;
        }
        private void montantTotalLabelClick(object sender, MouseButtonEventArgs e)
        {
            ConfirmationInscription.Visibility = Visibility.Visible;

            SelectionCoureurs.Visibility = Visibility.Hidden;
            RechercheCoureurs.Visibility = Visibility.Hidden;
            ListeRechercheCoureurs.Visibility = Visibility.Hidden;
            RechercheCourse.Visibility = Visibility.Hidden;
            stackPanelConnexion.Visibility = Visibility.Hidden;
            gridCourse.Visibility = Visibility.Hidden;

            labelbMontantTotal.Background = Brushes.GreenYellow;
            labelbMontantTotal.TextDecorations = TextDecorations.Underline;

            labelSelectionneCoureurs.Background = Brushes.LawnGreen;
            labelSelectionneCoureurs.TextDecorations = null;

            lbConnexion.Background = Brushes.LawnGreen;
            lbConnexion.TextDecorations = null;

            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LawnGreen;

            labelRechercheCoureurs.Background = Brushes.LawnGreen;
            labelRechercheCoureurs.TextDecorations = null;
        }
        private void butModifier_Click(object sender, RoutedEventArgs e)
        {

        }

        private void butSupprimer_Click(object sender, RoutedEventArgs e)
        {

        }

        private void butAjouter_Click(object sender, RoutedEventArgs e)
        {

        }
    }



}
