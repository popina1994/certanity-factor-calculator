using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.cfactor.zd130033d.Klase
{
   

    class Opazanje
    {
        public static Dictionary<String, Opazanje> observe = new Dictionary<String, Opazanje>();
        public String observation;
        public double mBelief;
        public double mDisbelief;

        public Opazanje(String observation, double mBelief = 0, double mDisbelief = 0)
        {
            this.observation = observation;
            this.mBelief = mBelief;
            this.mDisbelief = mDisbelief;
        }
    }
}
