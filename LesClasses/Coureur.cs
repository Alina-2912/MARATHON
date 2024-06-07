using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_201_MARATHON
{
    class Coureur
    {
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

        public int NumCoureur { get => numCoureur; set => numCoureur = value; }
        public string CodeClub { get => codeClub; set => codeClub = value; }
        public int NumFederation { get => numFederation; set => numFederation = value; }
        public string NomCoureur { get => nomCoureur; set => nomCoureur = value; }
        public string LienPhoto { get => lienPhoto; set => lienPhoto = value; }
        public string PrenomCoureur { get => prenomCoureur; set => prenomCoureur = value; }
        public string VilleCoureur { get => villeCoureur; set => villeCoureur = value; }
        public string Portable { get => portable; set => portable = value; }
        public char Sexe { get => sexe; set => sexe = value; }
        public string NumLicence { get => numLicence; set => numLicence = value; }
    }
}
