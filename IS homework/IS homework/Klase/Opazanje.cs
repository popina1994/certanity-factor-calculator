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
        String observation;
        double measureBelief;
        double measureDisbelief;

        public double MeasureOfBelief
        {
            get
            {
                return measureBelief;
            }
            set
            {
                measureBelief = value;
            }
        }

        public double MeasureOfDisbelief
        {
            get
            {
                return measureDisbelief;
            }
            set
            {
                measureDisbelief = value;
            }
        }

        public String Observation
        {
            get
            {
                return observation;
            }
            set
            {
                observation = value;
            }
        }

        public Opazanje(String observation, double mBelief = 0, double mDisbelief = 0)
        {
            this.observation = observation;
            this.measureBelief = mBelief;
            this.measureDisbelief = mDisbelief;
        }
    }
}
