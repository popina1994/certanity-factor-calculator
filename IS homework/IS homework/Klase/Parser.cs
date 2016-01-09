using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace etf.cfactor.zd130033d.Klase
{
    public class Error : Exception
    {
        public Error(string message) 
        {
        }
    }

    public class Parser

    {


        private static void InfixToPostfix(String[] rule, int begin, int end, out ArrayList postfix)
        {
            Stack s = new Stack();
            postfix = new ArrayList();
            int rank = 0;
            // Denotes if negation is last expression
            //
            bool addMinus = false;
            for (int idx = begin; idx < end; idx++)
            {

                switch (rule[idx])
                {
                    case "(":
                        s.Push("(");
                        break;
                    case ")":
                        String top = (String)s.Peek();
                        while (!top.Equals("(") && s.Count > 0)
                        {
                            if (top.Equals("I") || top.Equals("ILI"))
                            {
                                rank--;
                                if (rank < 1)
                                    throw new Error("Недовољан број речи(код И и ИЛИ"); 
                            }
                            
                            postfix.Add(top);
                            s.Pop();
                            top = (String)s.Peek();
                        }
                        if (!top.Equals("("))
                            throw new Error("Нема леве заграде");

                        break;
                    case "I":
                        s.Push("I");
                        break;
                    case "ILI":
                        s.Push("ILI");
                        break;
                    case "-":
                        addMinus = true;
                        break;
                    default:
                        if (!Regex.IsMatch(rule[idx], @"^[a-zA-Z]+$"))
                            throw new Error("Неисправна реч, исправна мора да има само слова");

                        postfix.Add(rule[idx]);
                        if (addMinus) {
                            postfix.Add(rule[idx - 1]);
                            addMinus = false;
                        }
                        rank++;
                        break;
                }
                if (addMinus && !rule[idx].Equals("-"))
                    throw new Error("Неисправно стављена негација");
            }
            if (addMinus)
                throw new Error("Неисправно стављена негација");

            while (s.Count != 0)
            {
                postfix.Add(s.Peek());
                s.Pop();
                rank--;
            }
            if (rank != 1)
                throw new Error("Недовољан број речи(код И и ИЛИ");
        }

        // PARAMETERS:
        // rule - rule which is checked if is valid. 
        // arrParameters - last 
        //
        // RETURN: in case of illegal rule, returns false, else true.
        // 
        public static void Check(String rule, out String[] arrParameters) 
        {
            arrParameters = rule.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);

            if (!arrParameters[0].Equals("AKO"))
                throw new Error("Нема AKO");

            int len = arrParameters.Length;
            if (!arrParameters[len - 2].Equals(")"))
                throw new Error("Нема десне заграде");

            if (!arrParameters[len - 4].Equals("("))
                throw new Error("Нема леве заграде");

            if (!arrParameters[len - 5].Equals("ONDA"))
                throw new Error("Нема ОNDA");

            double dFactor;
            if (!Double.TryParse(arrParameters[len - 3], out dFactor))
                throw new Error("Фактор није број");

            int iBegin = 1, iEnd = len - 5;

            ArrayList postfix;
            InfixToPostfix(arrParameters, iBegin, iEnd, out postfix);

         }



    }
}


