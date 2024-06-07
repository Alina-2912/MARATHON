using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_201_MARATHON.LesClasses
{
    class Course
    {

        private int numCourse;
        private double distance;
        private string heureDepart;
        private double prixInscription;

        public int NumCourse { get => numCourse; set => numCourse = value; }
        public double Distance { get => distance; set => distance = value; }
        public string HeureDepart { get => heureDepart; set => heureDepart = value; }
        public double PrixInscription { get => prixInscription; set => prixInscription = value; }
    }
}
