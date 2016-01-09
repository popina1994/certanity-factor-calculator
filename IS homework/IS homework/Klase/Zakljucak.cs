using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace etf.cfactor.zd130033d.Klase
{
    class Zakljucak
    {
        public String concName;

        public static Dictionary<String, Zakljucak> conclusion = new Dictionary<String, Zakljucak>();

        public Zakljucak(String zak)
        {
            this.concName = zak;
        }
    }
}
