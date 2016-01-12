using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace etf.cfactor.zd130033d.Klase
{
    class Pravilo
    {
        // Index of ListBox.
        //         
        public static Dictionary<String, Pravilo> rules = new Dictionary<String, Pravilo>();
        ArrayList postfix;
        String[] paramList;
        String rule;
        double measureOfBelief;
        double measureOfDisBelief;
        public int refCount;
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
