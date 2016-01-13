using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.cfactor.zd130033d.Klase
{

    public enum STATEZ { BOOT, EXEC, FINISH };
    /// <summary>
    /// Класа за закључке.
    /// </summary>
    class Zakljucak
    {

        
        /// <summary>
        /// Име закључка
        /// </summary>
        private String concName;
        private double measureOfBelief = 0;
        private double measureOfDisBelief = 0;

        /// <summary>
        /// CF датог закључка.
        /// </summary>
        private double certanityFactor  = 0;

        /// <summary>
        /// Стање при рачунању (може бити у BOOT - није кренуло израчунавање, EXEX - рачуна се, FINISH - завршило рачунање).
        /// </summary>
        private STATEZ state = STATEZ.BOOT;

        /// <summary>
        ///  Списак свих "регистрованих" закључака који треба да се израчунају.
        /// </summary>
        public static Dictionary<String, Zakljucak> conclusion = new Dictionary<String, Zakljucak>();

        /// <summary>
        /// Броји у колико још правила постоји да није израчунато.
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


       

        public Zakljucak(String zak)
        {
            this.concName = zak;
        }

        /// <summary>
        /// Ажурирај CF датог закључка, на основу MB и MD претпоставке где се он појављује као закључак.
        /// </summary>
        /// <param name="o"> Претпоставка </param>
        /// <param name="probMB"> Вероватноћа исправности правила. </param>
        /// <param name="probMD">  Вероватноћа неисправности правила. </param>
        public void Update(Opazanje o, double probMB, double probMD = 0)
        {
            // cf od pretpostavke.
            //
            double cf = o.MeasureOfBelief - o.MeasureOfDisbelief;
            // Racunaju se MB i MD od pretpostavke
            //
            o.MeasureOfBelief = probMB * Math.Max(0, cf);
            o.MeasureOfDisbelief = probMD * Math.Max(0, cf);

            // Mera poverenja u zakljucak.
            //
            measureOfBelief = measureOfBelief + o.MeasureOfBelief - measureOfBelief * o.MeasureOfBelief;
            measureOfDisBelief = measureOfDisBelief + o.MeasureOfDisbelief - measureOfDisBelief * o.MeasureOfDisbelief;
            certanityFactor = measureOfBelief - measureOfDisBelief;
        }

    }
}
