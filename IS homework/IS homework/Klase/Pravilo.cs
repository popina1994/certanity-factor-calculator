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

        public Pravilo(String rule, ArrayList postfix, String[] paramList)
        {
            this.postfix = postfix;
            this.paramList = paramList;
        }
    }
}
