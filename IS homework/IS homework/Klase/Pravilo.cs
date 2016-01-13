using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace etf.cfactor.zd130033d.Klase
{
    /// <summary>
    /// Класа за правила.
    /// </summary>
    class Pravilo
    {
        /// <summary>
        /// Списак свих "регистрованих" правила.
        /// </summary>
        public static Dictionary<String, Pravilo> rules = new Dictionary<String, Pravilo>();

        /// <summary>
        /// Постфикс датог израза.
        /// </summary>
        ArrayList postfix;

        /// <summary>
        /// Листа параметара.
        /// </summary>
        String[] paramList;

        /// <summary>
        /// Правило, ради дебаговања лакшег.
        /// </summary>
        String rule;

        double measureOfBelief;
        double measureOfDisBelief;



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


        public string Rule
        {
            get
            {
                return rule;
            }
            set
            {
                rule = value;
            }
        }

        public String[] ParamList
        {
            get
            {
                return paramList;
            }
            set
            {
                paramList = value;
            }

        }

        public ArrayList Postfix
        {
            get
            {
                return postfix;
            }
            set
            {
                postfix = value;
            }
        }

        public Pravilo(String rule, ArrayList postfix, String[] paramList)
        {
            this.postfix = postfix;
            this.paramList = paramList;
            this.rule = rule;
        }
    }
}
