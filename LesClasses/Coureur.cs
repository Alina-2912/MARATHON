using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_201_MARATHON
{
    public class Coureur : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int numCoureur;
        private string codeClub;
        private int numFederation;
        private string nomCoureur;
        private string lienPhoto;
        private string prenomCoureur;
        private string villeCoureur;
        private string portable;
        private char sexe;
        private string numLicence;

        public Coureur()
        {
        }

        public Coureur(int numCoureur, int numFederation, string nomCoureur, string prenomCoureur, string villeCoureur)
        {
            NumCoureur = numCoureur;
            NumFederation = numFederation;
            NomCoureur = nomCoureur;
            PrenomCoureur = prenomCoureur;
            VilleCoureur = villeCoureur;
        }

        public Coureur(int numCoureur, string codeClub, int numFederation, string nomCoureur, string lienPhoto, string prenomCoureur, string villeCoureur, string portable, char sexe, string numLicence)
        {
            NumCoureur = numCoureur;
            CodeClub = codeClub;
            NumFederation = numFederation;
            NomCoureur = nomCoureur;
            LienPhoto = lienPhoto;
            PrenomCoureur = prenomCoureur;
            VilleCoureur = villeCoureur;
            Portable = portable;
            Sexe = sexe;
            NumLicence = numLicence;
        }

        public int NumCoureur
        {
            get => numCoureur;
            set
            {
                if (numCoureur != value)
                {

                    numCoureur = value;
                    OnPropertyChanged(nameof(NumCoureur));
                }
            }
        }

        public string CodeClub
        {
            get => codeClub;
            set
            {
                if (codeClub != value)
                {
                    codeClub = value;
                    OnPropertyChanged(nameof(CodeClub));
                }
            }
        }
        public int NumFederation
        {
            get => numFederation;
            set
            {
                if (numFederation != value)
                {
                    numFederation = value;
                    OnPropertyChanged(nameof(NumFederation));
                }
            }
        }
        public string NomCoureur
        {
            get => nomCoureur;
            set
            {
                if (nomCoureur != value)
                {
                    nomCoureur = value;
                    OnPropertyChanged(nameof(NomCoureur));
                }
            }

        }
        public string LienPhoto
        {
            get => lienPhoto;
            set
            {
                if (lienPhoto != value)
                {
                    lienPhoto = value;
                    OnPropertyChanged(nameof(LienPhoto));
                }
            }

        }
        public string PrenomCoureur
        {
            get => prenomCoureur;
            set
            {
                if (prenomCoureur != value)
                {
                    prenomCoureur = value;
                    OnPropertyChanged(nameof(PrenomCoureur));
                }
            }

        }
        public string VilleCoureur
        {
            get => villeCoureur;
            set
            {
                if (villeCoureur != value)
                {
                    villeCoureur = value;
                    OnPropertyChanged(nameof(VilleCoureur));
                }
            }

        }
        public string Portable
        {
            get => portable;
            set
            {
                if (portable != value)
                {
                    portable = value;
                    OnPropertyChanged(nameof(Portable));
                }
            }

        }
        public char Sexe
        {
            get => sexe;
            set
            {
                if (sexe != value)
                {
                    sexe = value;
                    OnPropertyChanged(nameof(Sexe));
                }
            }

        }
        public string NumLicence
        {
            get => numLicence;
            set
            {
                if (numLicence != value)
                {
                    numLicence = value;
                    OnPropertyChanged(nameof(NumLicence));
                }
            }

        }

        private void OnPropertyChanged(string propertyName)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public List<Coureur> ListCoureurs()
        {

            string login = "dvornyka";
            string password = "HiXFTp";
            List<Coureur> coureurs = new List<Coureur>();
            string connectionString = $"Server=srv-peda-new;" +
                                      "Port=5433;" +
                                      "Database=beaune_sae;" +
                                      "Search Path=wpfcourse;" +
                                      $"User Id={login};" +
                                      $"Password={password};";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {

                connection.Open();
                string query = "SELECT num_coureur, code_club, num_federation, nom_coureur, lien_photo, prenom_coureur, ville_coureur, portable, sexe, num_licence FROM COUREUR";

                using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Coureur coureur = new Coureur
                            {
                                NumCoureur = reader.GetInt32(reader.GetOrdinal("num_coureur")),
                                CodeClub = reader.GetString(reader.GetOrdinal("code_club")),
                                NumFederation = reader.GetInt32(reader.GetOrdinal("num_federation")),
                                NomCoureur = reader.GetString(reader.GetOrdinal("nom_coureur")),
                                LienPhoto = reader.GetString(reader.GetOrdinal("lien_photo")),
                                PrenomCoureur = reader.GetString(reader.GetOrdinal("prenom_coureur")),
                                VilleCoureur = reader.GetString(reader.GetOrdinal("ville_coureur")),
                                Portable = reader.GetString(reader.GetOrdinal("portable")),
                                Sexe = reader.GetChar(reader.GetOrdinal("sexe")),
                                NumLicence = reader.GetString(reader.GetOrdinal("num_licence"))
                            };
                            coureurs.Add(coureur);
                        }
                    }
                }
            }
            return coureurs;
        }

        public override string? ToString()
        {
            return $"Num: {NumCoureur}, Nom: {NomCoureur}, Prenom: {PrenomCoureur}, Ville: {VilleCoureur}, Federation: {NumFederation}"; ;
        }
    }



}
