using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SAE_201_MARATHON.LesClasses
{
    class Agent
    {
        private int numAgent;
        private string loginAgent;
        private string mdpAgent;

        public int NumAgent { get => numAgent; set => numAgent = value; }
        public string LoginAgent { get => loginAgent; set => loginAgent = value; }
        public string MdpAgent { get => mdpAgent; set => mdpAgent = value; }
    }
}
