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
        private String message;
        public Error(string message) 
        {
            this.message = message;
        }
    
        public override String ToString()
        {
            return message;
        }
    }

    public class Parser

    {

        public static bool IsWord(String s)
        {
            return Regex.IsMatch(s, @"^[a-zA-Z1-9]+$");
        }

        // Because minimum and maximum are associative functions it isn't neccecary postfix to be in "right" order.
        //
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
                                    throw new Error("Недовољан број речи(код И и ИЛИ)  или превише речи"); 
                            }
                            
                            postfix.Add(top);
                            s.Pop();
                            top = (String)s.Peek();
                        }
                        if (!top.Equals("("))
                            throw new Error("Нема леве заграде");
                        else
                            s.Pop();

                        break;
                    case "I":
                        s.Push("I");
                        break;
                    case "ILI":
                        s.Push("ILI");
                        break;
                    case "-":
                        if (addMinus)
                            throw new Error("Неисправно стављена негација");

                        addMinus = true;
                        break;
                    default:
                        if (!IsWord(rule[idx]))
                            throw new Error("Неисправна реч, исправна мора да има само слова и бројеве");

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
                throw new Error("Недовољан број речи(код И и ИЛИ) или превише речи");
        }

        // PARAMETERS:
        // rule - rule which is checked if is valid. 
        // arrParameters - last 
        //
        // RETURN: in case of illegal rule, returns false, else true.
        // 
        public static void Check(String rule, out String[] arrParameters, out ArrayList postfix) 
        {
            arrParameters = rule.Split((char[])null, StringSplitOptions.RemoveEmptyEntries);
            int len = arrParameters.Length;

            if (len < 7)
                throw new Error("Недовољан број параметара у правилу");

            if (!arrParameters[0].Equals("AKO"))
                throw new Error("Нема AKO");

            if (!IsWord(arrParameters[len - 1]))
                throw new Error("Неисправна реч, исправна мора да има само слова и бројеве");

            if (!arrParameters[len - 2].Equals(")"))
                throw new Error("Нема десне заграде");

            if (!arrParameters[len - 4].Equals("("))
                throw new Error("Нема леве заграде");

            if (!arrParameters[len - 5].Equals("ONDA"))
                throw new Error("Нема ОNDA");

            double dFactor;
            if (!Double.TryParse(arrParameters[len - 3], out dFactor))
                throw new Error("Фактор није број");
            if (dFactor > 1 || dFactor < 0)
                throw new Error("Вероватноћа закључка није добра");
            int iBegin = 1, iEnd = len - 5;

            InfixToPostfix(arrParameters, iBegin, iEnd, out postfix);
            Stack s = new Stack();
            foreach (String element in postfix)
            {
                if (element.Equals("I") || element.Equals("ILI"))
                    s.Pop();
                else if (element.Equals("-")) ;
                else s.Push(element);
            }
            if (s.Count > 1)
                throw new Error("Превише претпоставки");

        }

        public static void GetObservations(ArrayList postfix, out ArrayList observe)
        {
            observe = new ArrayList();
            foreach (var elem in postfix) 
                if (!elem.Equals("I") && !elem.Equals("ILI") && !elem.Equals("-"))
                {
                    observe.Add(elem);
                }
        }


    }
}


