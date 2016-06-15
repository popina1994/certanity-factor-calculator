
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace etf.cfactor.zd130033d.Klase
{

    /// <summary>
    /// Имплементира алгоритам.
    /// </summary>
    class Algoritam
    {

        enum STATE { NOT_VISITED, VISITING, VISITED };

        /// <summary>
        /// Листа свих параметара сваког правила, ради лакшег приступа по реду.
        /// </summary>
        private static List<String[]> listParam;
        /// <summary>
        /// Листа вероватноћа закључака правила по реду, ради лакшег приступа по реду.
        /// </summary>
        private static List<double> listProbability;
        /// <summary>
        /// Листа закључака правила по реду, ради лакшег приступа по  реду.
        /// </summary>
        private static List<Zakljucak> listConclusion;


        /// <summary>
        /// Листа пoстфикса сваког правила, ради лакшег приступа по реду.
        /// </summary>
        private static List<ArrayList> listPostfix;

        /// <summary>
        /// Памти кораке ако је одабран корак по корак мод.
        /// </summary>

        public static List<String> stepByStep;
        /// <summary>
        /// Означава у ком кораку је тренутно.
        /// </summary>
        public static int curStep = 0;

        /// <summary>
        /// Означава који мод је изабран.
        /// </summary>
        public static bool stepMode = false;

        /// <summary>
        /// Иницијализује и ресетује структуре које се користе код рачунања.
        /// </summary>
        private static void MakeMatrix()
        {
           
            // Brisemo staru matricu.
            //
            listParam = new List<string[]>();
            listProbability = new List<double>();
            listConclusion = new List<Zakljucak>();
            listPostfix = new List<ArrayList>();

            // Izracunavanje krece ispocetka.
            //
            foreach (KeyValuePair<String, Zakljucak> entry in Zakljucak.conclusion)
            {
                entry.Value.State = STATEZ.BOOT;
            }

            foreach (KeyValuePair<String, Zakljucak> elem in Zakljucak.conclusion)
            {
                elem.Value.RefCount = 0;
                elem.Value.MeasureOfBelief = 0;
                elem.Value.MeasureOfDisbelief = 0;
            }


            foreach (KeyValuePair<string, Pravilo> elem in Pravilo.rules)
            {
                Pravilo p = elem.Value;
                
                // Dodajemo postfix.
                //
                listPostfix.Add(p.Postfix);

                // Sadrzi zakljucak, pretpostavke i ostale simbole.
                //
                String[] paramList = p.ParamList;
                listParam.Add(paramList);

                // Zakljucak.
                //
                String conclusion = Parser.ExtractConclusion(paramList);
                Zakljucak z = Zakljucak.conclusion[conclusion];
                listConclusion.Add(z);

                // Brojimo koliko puta postoji neki zakljucak.
                //
                z.RefCount++;

                // Dodaj u listu verovatnoce zakljucaka.
                //
                listProbability.Add(Parser.ExtractProbability(paramList));      
            }
        }

        /// <summary>
        /// На основу израза који је у постфиксу израчунава measure of belief и measure of disbelief од претпоставке.
        /// </summary>
        /// <param name="postfix"> Израз којие се користи да се одради Certanity factor од претпоставке. </param>
        /// <returns></returns>
       private static Opazanje CalcRule(ArrayList postfix)
        {
            Stack<Opazanje> s = new Stack<Opazanje>();
            foreach(String elem in postfix)
            {
                Zakljucak z;
                Opazanje operand = new Opazanje("");
                Opazanje o;
                // Ako je operand.
                //
                if (!Parser.IsKeyWord(elem)) {
                   

                    // Ako postoji medju zakljuccima i racuna se.
                    //
                    if (Zakljucak.conclusion.TryGetValue(elem, out z))
                    {
                        // U slucaju da se desi rekurzija.
                        ///
                        if (z.State == STATEZ.EXEC)
                            throw new Error("Рекурзија, бајо мој");

                        
                        // Treba rekurzivno da izracunamo.
                        //
                        else if (z.State == STATEZ.BOOT)
                        {
                            Calc(z);
                        }
                        // U slucaju da je zakljucak vec zavrsio izracunavanje.
                        //
                        //s.Push(elem);
                        operand.MeasureOfBelief = z.MeasureOfBelief;
                        operand.MeasureOfDisbelief = z.MeasureOfDisbelief;
                    }

                    // Ako je medju opazanjima.
                    //
                    else if(Opazanje.observe.TryGetValue(elem, out o))
                    {
                        //s.Push(elem);
                        operand.MeasureOfBelief = o.MeasureOfBelief;
                        operand.MeasureOfDisbelief = o.MeasureOfDisbelief;
                    }
                    else
                    {
                        throw new Error("Не постоји опажање" + elem);
                    }
                            
                    s.Push(operand);
                }

                // Ako je unarni operator.
                //
                else if (elem.Equals("-"))
                {
                    operand = s.Peek();
                    s.Pop();
                    // Suprotno se menja suprotnim. Ono drugo postaje 0.
                    //
                    double tmp;

                    // Proverava se za operand da li je korisceno measure of melief ili measure of disbelief i racuna "suprotno" u odnosu na njega.
                    //
                    if (operand.MeasureOfBelief != 0)
                    {
                        tmp = operand.MeasureOfDisbelief;
                        operand.MeasureOfDisbelief = operand.MeasureOfBelief;
                        operand.MeasureOfBelief = tmp;
                    }
                    else
                    {
                        tmp = operand.MeasureOfBelief;
                        operand.MeasureOfBelief = operand.MeasureOfDisbelief;
                        operand.MeasureOfDisbelief = tmp;
                    }
                    s.Push(operand);
                }
                else if (elem.Equals("I"))
                {
                    Opazanje o1 = s.Peek();
                    s.Pop();
                    Opazanje o2 = s.Peek();
                    s.Pop();

                    // Posto je I operator za MB se racuna min, za MD max.
                    //
                    operand.MeasureOfBelief = Math.Min(o1.MeasureOfBelief, o2.MeasureOfBelief);
                    operand.MeasureOfDisbelief = Math.Max(o1.MeasureOfDisbelief, o2.MeasureOfDisbelief);
                    s.Push(operand);

                }
                else if (elem.Equals("ILI"))
                {
                    Opazanje o1 = s.Peek();
                    s.Pop();
                    Opazanje o2 = s.Peek();
                    s.Pop();

                    // Posto je ILI operator za MD se racuna min, za MB max.
                    operand.MeasureOfBelief = Math.Max(o1.MeasureOfBelief, o2.MeasureOfBelief);
                    operand.MeasureOfDisbelief = Math.Min(o1.MeasureOfDisbelief, o2.MeasureOfDisbelief);
                    s.Push(operand);
                }
                else
                {
                    throw new Error("Пијан си као летва");
                }
            }

            Opazanje op = s.Peek();
            s.Pop();
            return op;
        }
       
        /// <summary>
        ///  Израчуна MB и MD од закључка и стави га у zaklucak.
        /// </summary>
        /// <param name="zakljucak"> Чије рачунање се ради. </param>
        private static void Calc(Zakljucak zakljucak)
        {
            zakljucak.State = STATEZ.EXEC;

            // Ide po istim zakljuccima 
            for (int idx = 0; idx < listConclusion.Count; idx ++)
            {
                // Na osnovu kog pravila i nakon sto se izrazuna sta se menja.
                //
                if (listConclusion[idx] == zakljucak)
                {
                    // Izracunato sta treba.
                    //
                    int tmp = idx + 1;
                    stepByStep.Add("Rekurzijom se racuna: zakljucak " + zakljucak.ConclusionName + " u pravilu " + tmp);
                    Opazanje o = CalcRule(listPostfix[idx]);

                    // Azuriraj Measure of Belief i Disbelief zakljucka.
                    //
                    zakljucak.Update(o, listProbability[idx]);
                    stepByStep.Add("Rekurzijom je dobijeno da zakljucak (azuriran)" + zakljucak.ConclusionName + " u pravilu " + tmp + " ima mb: " + zakljucak.MeasureOfBelief + " md " + zakljucak.MeasureOfDisbelief);

                    // Jedno je izracunato, smanji broj, ako je izracunat sav broj kraj racunanja.
                    //
                    zakljucak.RefCount--;
                    if (zakljucak.RefCount == 0)
                        break;
                }
            }
            zakljucak.State = STATEZ.FINISH;

        }

        /// <summary>
        /// Wraper функција за рачунање CF закључка.
        /// </summary>
        /// <param name="z"> Закључак чији CF се рачуна. </param>
        public static void CertanityFactor(Zakljucak z)
        {
            MakeMatrix();
            Calc(z);
            stepByStep.Add("Rezultat kumulativni certanity factor " + System.Convert.ToString(z.CertanityFactor) + " zakljucka " + z.ConclusionName);           
            
        }
        

    }
}
