using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_201_MARATHON.LesClasses
{
    class Inscription
    {
        private int numInscription;
        private int numCourse;
        private DateTime dateInscription;

        public int NumInscription { get => numInscription; set => numInscription = value; }
        public int NumCourse { get => numCourse; set => numCourse = value; }
        public DateTime DateInscription { get => dateInscription; set => dateInscription = value; }
    }
}
