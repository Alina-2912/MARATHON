using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_201_MARATHON.LesClasses
{
    class Inscription2
    {
        private int numInscription;
        private int numCoureur;
        private DateTime tempsPrevu;

        public int NumInscription { get => numInscription; set => numInscription = value; }
        public int NumCoureur { get => numCoureur; set => numCoureur = value; }
        public DateTime TempsPrevu { get => tempsPrevu; set => tempsPrevu = value; }
    }
}
