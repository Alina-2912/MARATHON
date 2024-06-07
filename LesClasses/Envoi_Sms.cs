using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_201_MARATHON.LesClasses
{
    class Envoi_Sms
    {
        private int numAmi;
        private int numInscription;
        private string portableSms;

        public int NumAmi { get => numAmi; set => numAmi = value; }
        public int NumInscription { get => numInscription; set => numInscription = value; }
        public string PortableSms { get => portableSms; set => portableSms = value; }
    }
}
