using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection.Emit;
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

        //public void ButtonConnexion(object sender, RoutedEventArgs e)
        //{
        //    string login = tbLogin.Text;
        //    string password = pswrdBox.Password;

        //    string connectionString = $"Server=srv-peda-new;" +
        //                              "port=5433;" +
        //                              "Database=beaune_sae;" +
        //                              "Search Path=wpfcourse;" +
        //                              $"uid={login};" +
        //                              $"password={password};";

        //    using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
        //    {
        //        try
        //        {
        //            connection.Open();

        //            // If connection is successful, change the stack panel visibility
        //            stackPanelConnexion.Visibility = Visibility.Hidden;
        //            RechercheCourse.Visibility = Visibility.Visible;
        //            gridCourse.Visibility = Visibility.Visible;
        //            RechercheCourseBorder.Visibility = Visibility.Visible;
        //            lbTitreSelectionnercourse.Visibility = Visibility.Visible;

        //            lbConnexion.Visibility = Visibility.Visible;
        //            labelRechercheCourse.Visibility = Visibility.Visible;
        //            labelRechercheCoureurs.Visibility = Visibility.Visible;
        //            labelSelectionneCoureurs.Visibility = Visibility.Visible;
        //            labelbMontantTotal.Visibility = Visibility.Visible;

        //            lbDeconnexion.Visibility = Visibility.Visible;
        //            borderlbDeconnex.Visibility = Visibility.Visible;
        //            lbDeconnexion.Background = Brushes.LightPink;
        //            lbDeconnexion.TextDecorations = null;
        //            labelRechercheCoureurs.Background = Brushes.LightPink;
        //            labelRechercheCoureurs.TextDecorations = null;

        //            labelRechercheCourse.Background = Brushes.HotPink;
        //            labelRechercheCourse.TextDecorations = TextDecorations.Underline;
        //        }
        //        catch (Exception ex)
        //        {
        //            // Handle exceptions and display error message
        //            MessageBox.Show("Identifiant ou mot de passe incorrect", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
        //        }
        //    }
        //}


        public void ButtonConnexion(object sender, RoutedEventArgs e)
        {

            stackPanelConnexion.Visibility = Visibility.Hidden;
            RechercheCourse.Visibility = Visibility.Visible;
            gridCourse.Visibility = Visibility.Visible;
            RechercheCourseBorder.Visibility = Visibility.Visible;
            lbTitreSelectionnercourse.Visibility = Visibility.Visible;

            lbDeconnexion.Visibility = Visibility.Visible;
            borderlbDeconnex.Visibility = Visibility.Visible;
            labelRechercheCourse.Visibility = Visibility.Visible;
            labelRechercheCoureurs.Visibility = Visibility.Visible;
            labelSelectionneCoureurs.Visibility = Visibility.Visible;
            labelbMontantTotal.Visibility = Visibility.Visible;

            lbDeconnexion.Background = Brushes.LightPink;
            lbDeconnexion.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.LightPink;
            labelRechercheCoureurs.TextDecorations = null;

            labelRechercheCourse.Background = Brushes.HotPink;
            labelRechercheCourse.TextDecorations = TextDecorations.Underline;

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
            lbTitreRechercherCoureur.Visibility = Visibility.Visible;
            ListeRechercheCoureurs.Visibility = Visibility.Visible;
            RechercheCourseBorder.Visibility = Visibility.Hidden;
            lbTitreSelectionnercourse.Visibility = Visibility.Hidden;

            gridCourse.Visibility = Visibility.Hidden;

            labelRechercheCoureurs.Background = Brushes.HotPink;
            labelRechercheCoureurs.TextDecorations = TextDecorations.Underline;

            lbDeconnexion.Background = Brushes.LightPink;
            lbDeconnexion.TextDecorations = null;

            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LightPink;

            labelSelectionneCoureurs.TextDecorations = null;
            labelSelectionneCoureurs.Background = Brushes.LightPink;
        }

        private void Button_Suivant_2(object sender, RoutedEventArgs e)
        {
            RechercheCoureurs.Visibility = Visibility.Hidden;
            lbTitreRechercherCoureur.Visibility = Visibility.Hidden;
            ListeRechercheCoureurs.Visibility = Visibility.Hidden;
            SelectionCoureurs.Visibility = Visibility.Visible;
            RechercheCourseBorder.Visibility = Visibility.Hidden;
            lbTitreSelectionnercourse.Visibility = Visibility.Hidden;

            labelSelectionneCoureurs.Background = Brushes.HotPink;
            labelSelectionneCoureurs.TextDecorations = TextDecorations.Underline;

            lbDeconnexion.Background = Brushes.LightPink;
            lbDeconnexion.TextDecorations = null;

            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LightPink;

            labelRechercheCoureurs.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.LightPink;
        }

        private void Button_Precedent_1(object sender, RoutedEventArgs e)
        {
            RechercheCourse.Visibility = Visibility.Visible;
            RechercheCourseBorder.Visibility = Visibility.Visible;
            lbTitreSelectionnercourse.Visibility = Visibility.Visible;
            RechercheCoureurs.Visibility = Visibility.Hidden;
            lbTitreRechercherCoureur.Visibility = Visibility.Hidden;
            ListeRechercheCoureurs.Visibility = Visibility.Hidden;
            gridCourse.Visibility = Visibility.Visible;

            labelRechercheCourse.Background = Brushes.HotPink;
            labelRechercheCourse.TextDecorations = TextDecorations.Underline;

            lbDeconnexion.Background = Brushes.LightPink;
            lbDeconnexion.TextDecorations = null;

            labelRechercheCoureurs.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.LightPink;

            labelbMontantTotal.Background = Brushes.LightPink;
            labelbMontantTotal.TextDecorations = null;

            labelSelectionneCoureurs.Background = Brushes.LightPink;
            labelSelectionneCoureurs.TextDecorations = null;
        }

        private void Button_Precedent_2(object sender, RoutedEventArgs e)
        {
            RechercheCoureurs.Visibility = Visibility.Visible;
            lbTitreRechercherCoureur.Visibility = Visibility.Visible;
            ListeRechercheCoureurs.Visibility = Visibility.Visible;
            SelectionCoureurs.Visibility = Visibility.Hidden;

            labelRechercheCoureurs.Background = Brushes.HotPink;
            labelRechercheCoureurs.TextDecorations = TextDecorations.Underline;

            labelSelectionneCoureurs.Background = Brushes.LightPink;
            labelSelectionneCoureurs.TextDecorations = null;

            lbDeconnexion.Background = Brushes.LightPink;
            lbDeconnexion.TextDecorations = null;

            labelRechercheCourse.Background = Brushes.LightPink;
            labelRechercheCourse.TextDecorations = null;

            labelbMontantTotal.Background = Brushes.LightPink;
            labelbMontantTotal.TextDecorations = null;
        }
        private void Button_Suivant_3(object sender, RoutedEventArgs e)
        {
            SelectionCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Visible;

            labelbMontantTotal.Background = Brushes.HotPink;
            labelbMontantTotal.TextDecorations = TextDecorations.Underline;

            lbDeconnexion.Background = Brushes.LightPink;
            lbDeconnexion.TextDecorations = null;

            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LightPink;

            labelRechercheCoureurs.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.LightPink;

            labelSelectionneCoureurs.Background = Brushes.LightPink;
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

            labelSelectionneCoureurs.Background = Brushes.HotPink;
            labelSelectionneCoureurs.TextDecorations = TextDecorations.Underline;

            labelRechercheCoureurs.Background = Brushes.LightPink;
            labelRechercheCoureurs.TextDecorations = null;

            lbDeconnexion.Background = Brushes.LightPink;
            lbDeconnexion.TextDecorations = null;

            labelRechercheCourse.Background = Brushes.LightPink;
            labelRechercheCourse.TextDecorations = null;

            labelbMontantTotal.Background = Brushes.LightPink;
            labelbMontantTotal.TextDecorations = null;
        }

        private void Button_Deconnexion(object sender, RoutedEventArgs e)
        {
            stackPanelConnexion.Visibility = Visibility.Visible;
            RechercheCourse.Visibility = Visibility.Hidden;
            RechercheCourseBorder.Visibility = Visibility.Hidden;
            lbTitreSelectionnercourse.Visibility = Visibility.Hidden;

            lbDeconnexion.Background = Brushes.HotPink;
            lbDeconnexion.TextDecorations = TextDecorations.Underline;

            labelRechercheCourse.Background = Brushes.LightPink;
            labelRechercheCourse.TextDecorations = null;

            labelRechercheCoureurs.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.LightPink;

            gridCourse.Visibility = Visibility.Hidden;

            tbLogin.Text = string.Empty;
            pswrdBox.Password = string.Empty;

            lbDeconnexion.Visibility = Visibility.Hidden;
            borderlbDeconnex.Visibility = Visibility.Hidden;
            labelRechercheCourse.Visibility = Visibility.Hidden;
            labelRechercheCoureurs.Visibility = Visibility.Hidden;
            labelbMontantTotal.Visibility = Visibility.Hidden;
            labelSelectionneCoureurs.Visibility = Visibility.Hidden;
        }

        /*    --------------------    LABELS      -------------------      */
        private void DeconnexionLabelClick(object sender, MouseButtonEventArgs e)
        {
            stackPanelConnexion.Visibility = Visibility.Visible;

            RechercheCourse.Visibility = Visibility.Hidden;
            RechercheCourseBorder.Visibility = Visibility.Hidden;
            lbTitreSelectionnercourse.Visibility = Visibility.Hidden;
            RechercheCoureurs.Visibility = Visibility.Hidden;
            lbTitreRechercherCoureur.Visibility = Visibility.Hidden;
            ListeRechercheCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            SelectionCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            gridCourse.Visibility = Visibility.Hidden;
            lbDeconnexion.Visibility = Visibility.Hidden;
            borderlbDeconnex.Visibility = Visibility.Hidden;

            lbDeconnexion.Background = Brushes.HotPink;
            lbDeconnexion.TextDecorations = TextDecorations.Underline;

            labelRechercheCourse.Visibility = Visibility.Hidden;
            labelRechercheCoureurs.Visibility = Visibility.Hidden;
            labelSelectionneCoureurs.Visibility = Visibility.Hidden;
            labelbMontantTotal.Visibility = Visibility.Hidden;

            labelRechercheCourse.Background = Brushes.LightPink;
            labelRechercheCourse.TextDecorations = null;

            labelRechercheCoureurs.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.LightPink;

            labelSelectionneCoureurs.Background = Brushes.LightPink;
            labelSelectionneCoureurs.TextDecorations = null;

            labelbMontantTotal.Background = Brushes.LightPink;
            labelbMontantTotal.TextDecorations = null;

            tbLogin.Text = string.Empty;
            pswrdBox.Password = string.Empty;
        }
        private void rechercherCourseLabelClick(object sender, MouseButtonEventArgs e)
        {
            RechercheCourse.Visibility = Visibility.Visible;
            RechercheCourseBorder.Visibility = Visibility.Visible;
            lbTitreSelectionnercourse.Visibility = Visibility.Visible;

            stackPanelConnexion.Visibility = Visibility.Hidden;
            RechercheCoureurs.Visibility = Visibility.Hidden;
            lbTitreRechercherCoureur.Visibility = Visibility.Hidden;
            ListeRechercheCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            SelectionCoureurs.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            gridCourse.Visibility = Visibility.Visible;

            labelRechercheCourse.Background = Brushes.HotPink;
            labelRechercheCourse.TextDecorations = TextDecorations.Underline;

            lbDeconnexion.Background = Brushes.LightPink;
            lbDeconnexion.TextDecorations = null;

            labelRechercheCoureurs.TextDecorations = null;
            labelRechercheCoureurs.Background = Brushes.LightPink;

            labelSelectionneCoureurs.Background = Brushes.LightPink;
            labelSelectionneCoureurs.TextDecorations = null;

            labelbMontantTotal.Background = Brushes.LightPink;
            labelbMontantTotal.TextDecorations = null;

        }

        private void rechercherCoureursLabelClick(object sender, MouseButtonEventArgs e)
        {

            RechercheCoureurs.Visibility = Visibility.Visible;
            lbTitreRechercherCoureur.Visibility = Visibility.Visible;
            ListeRechercheCoureurs.Visibility = Visibility.Visible;

            SelectionCoureurs.Visibility = Visibility.Hidden;
            RechercheCourse.Visibility = Visibility.Hidden;
            RechercheCourseBorder.Visibility = Visibility.Hidden;
            lbTitreSelectionnercourse.Visibility = Visibility.Hidden;
            stackPanelConnexion.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            gridCourse.Visibility = Visibility.Hidden;

            labelRechercheCoureurs.Background = Brushes.HotPink;
            labelRechercheCoureurs.TextDecorations = TextDecorations.Underline;

            lbDeconnexion.Background = Brushes.LightPink;
            lbDeconnexion.TextDecorations = null;

            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LightPink;

            labelSelectionneCoureurs.Background = Brushes.LightPink;
            labelSelectionneCoureurs.TextDecorations = null;

            labelbMontantTotal.Background = Brushes.LightPink;
            labelbMontantTotal.TextDecorations = null;
        }


        private void selectionnerCoureursLabelClick(object sender, MouseButtonEventArgs e)
        {
            SelectionCoureurs.Visibility = Visibility.Visible;

            RechercheCoureurs.Visibility = Visibility.Hidden;
            lbTitreRechercherCoureur.Visibility = Visibility.Hidden;
            ListeRechercheCoureurs.Visibility = Visibility.Hidden;
            RechercheCourse.Visibility = Visibility.Hidden;
            RechercheCourseBorder.Visibility = Visibility.Hidden;
            lbTitreSelectionnercourse.Visibility = Visibility.Hidden;
            stackPanelConnexion.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            ConfirmationInscription.Visibility = Visibility.Hidden;
            gridCourse.Visibility = Visibility.Hidden;

            labelSelectionneCoureurs.Background = Brushes.HotPink;
            labelSelectionneCoureurs.TextDecorations = TextDecorations.Underline;

            lbDeconnexion.Background = Brushes.LightPink;
            lbDeconnexion.TextDecorations = null;

            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LightPink;

            labelRechercheCoureurs.Background = Brushes.LightPink;
            labelRechercheCoureurs.TextDecorations = null;

            labelbMontantTotal.Background = Brushes.LightPink;
            labelbMontantTotal.TextDecorations = null;
        }
        private void montantTotalLabelClick(object sender, MouseButtonEventArgs e)
        {
            ConfirmationInscription.Visibility = Visibility.Visible;

            SelectionCoureurs.Visibility = Visibility.Hidden;
            RechercheCoureurs.Visibility = Visibility.Hidden;
            lbTitreRechercherCoureur.Visibility = Visibility.Hidden;
            ListeRechercheCoureurs.Visibility = Visibility.Hidden;
            RechercheCourse.Visibility = Visibility.Hidden;
            RechercheCourseBorder.Visibility = Visibility.Hidden;
            lbTitreSelectionnercourse.Visibility = Visibility.Hidden;
            stackPanelConnexion.Visibility = Visibility.Hidden;
            gridCourse.Visibility = Visibility.Hidden;

            labelbMontantTotal.Background = Brushes.HotPink;
            labelbMontantTotal.TextDecorations = TextDecorations.Underline;

            labelSelectionneCoureurs.Background = Brushes.LightPink;
            labelSelectionneCoureurs.TextDecorations = null;

            lbDeconnexion.Background = Brushes.LightPink;
            lbDeconnexion.TextDecorations = null;

            labelRechercheCourse.TextDecorations = null;
            labelRechercheCourse.Background = Brushes.LightPink;

            labelRechercheCoureurs.Background = Brushes.LightPink;
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

        public void ContenuMontant(object sender, RoutedEventArgs e)
        {
            choixCourse.SelectionChanged += ContenuMontant;

            if (choixCourse.SelectedValue == choixMarathon)
            {
                labAfficheMontant.Content = 50 + " euros";
            }
            if (choixCourse.SelectedValue == choixSemiMarathon)
            {
                labAfficheMontant.Content = 30 + " euros";
            }
            if (choixCourse.SelectedValue == choix10km)
            {
                labAfficheMontant.Content = 25 + " euros";
            }
            if (choixCourse.SelectedValue == choixDuo)
            {
                labAfficheMontant.Content = 40 + " euros";
            }
            if (choixCourse.SelectedValue == choixRelais)
            {
                //labAfficheMontant.Content.Equals("70 euros");
                labAfficheMontant.Content = 70 + " euros";
            }
        }


    }


}
