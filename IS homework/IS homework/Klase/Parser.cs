using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Text.RegularExpressions;

namespace etf.cfactor.zd130033d.Klase
{
    /// <summary>
    /// Служи за евиденцију грешака.
    /// </summary>
    public class Error : Exception
    {
        private String message;
        public Error(String message) 
        {
            this.message = message;
        }
    
        public override String ToString()
        {
            return message;
        }
    }
    
    /// <summary>
    /// Садржи методе за парсирање израаза и регекс неких израза.
    /// </summary>
    public class Parser

    {
        /// <summary>
        ///  Кључне речи.
        /// </summary>
        private static readonly String[] keyWord = new String[7] { "AKO", "ONDA", "(", ")", "I", "ILI", "-"};

        /// <summary>
        /// Проверева да ли је реч по формату - само бројеви и слова.
        /// </summary>
        /// <param name="s"> Реч која се проверава.</param>
        /// <returns> true у случају да је реч по формату, иначе false.</returns>
        public static bool IsWord(String s)
        {
            return Regex.IsMatch(s, @"^[a-zA-Z1-9]+$");
        }

        /// <summary>
        /// Проверава да ли је реч кључна, тј. међу једним од "кључних".
        /// </summary>
        /// <param name="s"> Реч која се проверава. </param>
        /// <returns> true у случају да је реч кључна, иначе false</returns>
        public static bool IsKeyWord(String s)
        {
            foreach (String elem in keyWord)
            {
                if (s.Equals(elem))
                    return true;
            }
            return false;
        }

        /// <summary>
        /// Минимална дужина правила.
        /// </summary>
        private const int MIN_LEN = 7;

        /// <summary>
        /// Извлачи MB од правила.
        /// </summary>
        /// <param name="ruleParams"> Правило из кога се извлачи.</param>
        /// <returns> MB од правила. </returns>
        public static double ExtractProbability(String[] ruleParams) 
        {
            int len = ruleParams.Length;
            if (ruleParams.Length < MIN_LEN)
            {
                throw new Error("Недовољно параметара");
            }
            double cFactor;
            if (!Double.TryParse(ruleParams[len - 3], out cFactor))
                throw new Error("Фактор није број");
            return cFactor;
        }

        /// <summary>
        /// Извлачи закључак из правила.
        /// </summary>
        /// <param name="ruleParams">Правило из кога се извлачи</param>
        /// <returns>Закључак.</returns>
        public static String ExtractConclusion(String[] ruleParams)
        {
            int len = ruleParams.Length;
            if (ruleParams.Length < MIN_LEN)
            {
                throw new Error("Недовољно параметара");
            }
            return ruleParams[len - 1];
        }

        /// <summary>
        /// Из датог правила извлачи "леви" део и претвара у postfix.
        /// </summary>
        /// <param name="rule">Правило које се проверава </param>
        /// <param name="begin"> Одакле се чита правило. </param>
        /// <param name="end"> Докле се чита правило. </param>
        /// <param name="postfix"> Постфикс који се добија. </param>
        private static void InfixToPostfix(String[] rule, int begin, int end, out ArrayList postfix)
        {
            Stack<String> s = new Stack<String>();
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

        


        /// <summary>
        /// Парсира израз, проверава да ли је исправан и у случају исправног низ "параметара" је прослеђен у arrParameters.
        /// И postfix садржи postfix леве стране израза.
        /// </summary>
        /// <param name="rule"> Правило које се парсира.</param>
        /// <param name="arrParameters"> Низ испарсираних параметара. </param>
        /// <param name="postfix">Постфикс леве стране израза.</param>
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
            /*
            int cnt = 0;
            for (int idx = 0; idx < arrParameters.Length - 4; idx ++)
            {
                // Ako nije kljucna rec, jer idemo sigurno do ONDA.
                //
                if (!IsKeyWord(arrParameters[idx]))
                {
                    arrParameters[cnt++] = arrParameters[idx];
                } 
            }
            // Dodaj zakljucak na kraj.
            //
            arrParameters[cnt++] = arrParameters[arrParameters.Length - 1];
            Array.Resize(ref arrParameters, cnt);
            */
        }
    }
}


