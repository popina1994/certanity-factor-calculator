using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.cfactor.zd130033d.Klase
{

    public enum STATEZ { BOOT, EXEC, FINISH };

    class Zakljucak
    {

        

        private String concName;
        private double measureOfBelief = 0;
        private double measureOfDisBelief = 0;
        private double certanityFactor  = 0;
        private STATEZ state = STATEZ.BOOT;
        /// <summary>
        /// Broji koliko ima jos istih zakljucaka ciji MB i MD nisu izracunati.
        /// </summary>
        private int refCount = 0;

        public double MeasureOfBelief
        {
            get
            {
                return measureOfBelief;
            }
            set
            {
                measureOfBelief = value;
            }
        }

        public double MeasureOfDisbelief
        {
            get
            {
                return measureOfDisBelief;
            }
            set
            {
                measureOfDisBelief = value;
            }
        }

        public double CertanityFactor
        {
            get
            {
                return certanityFactor;
            }
            set
            {
                certanityFactor = value;
            }
        }

        public int RefCount
        {
            get
            {
                return refCount;
            }
            set
            {
                refCount = value;
            }
        }

        public String ConclusionName {
            get
            {
                return concName;
            }
            set
            {
                concName = value;
            }
        }
        
        public STATEZ State
        {
            get
            {
                return state;
            }
            set
            {
                state = value;
            }
        }


        public static Dictionary<String, Zakljucak> conclusion = new Dictionary<String, Zakljucak>();

        public Zakljucak(String zak)
        {
            this.concName = zak;
        }

        public void Update(Opazanje o, double probMB, double probMD = 0)
        {
            // cf od pretpostavke.
            //
            double cf = o.MeasureOfBelief - o.MeasureOfDisbelief;
            // Racunaju se MB i MD od pretpostavke
            //
            o.MeasureOfBelief = probMB * Math.Max(0, cf);
            o.MeasureOfDisbelief = probMD * Math.Max(0, cf);

            // Mera poverenja u zakljucak u 
            measureOfBelief = measureOfBelief + o.MeasureOfBelief - measureOfBelief * o.MeasureOfBelief;
            measureOfDisBelief = measureOfDisBelief + o.MeasureOfDisbelief - measureOfDisBelief * o.MeasureOfDisbelief;
            certanityFactor = measureOfBelief - measureOfDisBelief;
        }

    }
}
