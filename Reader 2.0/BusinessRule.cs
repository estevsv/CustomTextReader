using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CustomTextReader
{
    public class BusinessRule
    {
        /* 0 - spanish
           1 - normal
           2 - germany*/

        public decimal MediaCaracteres(DataTable dt)
        {
            decimal media = 0;
            foreach(DataRow row in dt.Rows)
            {
                media += int.Parse(row["Number of Characters"].ToString());
            }

            media = dt.Rows.Count > 0 ? media / dt.Rows.Count : 0;
            return media;
        }

        public Tuple<bool, string> CheckBreakPage(char word, string concatenateLetters)
        {
            if (word == '\n')
            {
                concatenateLetters += " ";
                return new Tuple<bool, string>(true, concatenateLetters);
            }
            return new Tuple<bool, string>(false, concatenateLetters);
        }
        public string SepareteSentencesSpanish(string originalText)
        {
            string concatenateSentences = "";
            string concatenateLetters = "";
            bool startLetter = false;
            for (int i = 0; i < originalText.Length; i++)
            {
                Tuple<bool, string> checkBreakPage = CheckBreakPage(originalText[i], concatenateLetters);
                if (checkBreakPage.Item1)
                    concatenateLetters = checkBreakPage.Item2;
                else
                {
                    if (concatenateLetters == "")
                        startLetter = true;
                    if (originalText[i] == '!' || originalText[i] == '.' || originalText[i] == '?')
                    {
                        concatenateLetters += originalText[i];
                        List<string> retorno = ComumExceptions(originalText, concatenateLetters, concatenateSentences, i);
                        concatenateLetters = retorno[0];
                        concatenateSentences = retorno[1];

                    }
                    else if (originalText[i] == '¿' || originalText[i] == '¡')
                    {
                        if (concatenateLetters.Count() > 3)
                        {
                            concatenateSentences += "*" + concatenateLetters;
                            concatenateLetters = "";
                            concatenateLetters += originalText[i];
                        }
                        else
                        {
                            concatenateLetters += originalText[i];
                        }
                    }
                    else if (!startLetter)
                    {
                        concatenateLetters += originalText[i];
                    }
                    else
                    {
                        if (!(originalText[i] == ' '))
                            concatenateLetters += originalText[i];
                        startLetter = false;
                    }
                }
            }

            return concatenateSentences;
        }

        public string SepareteSentencesNormal(string originalText)
        {
            string concatenateSentences = "";
            string concatenateLetters = "";
            bool startLetter = false;
            for (int i = 0; i < originalText.Length; i++)
            {
                Tuple<bool, string> checkBreakPage = CheckBreakPage(originalText[i], concatenateLetters);
                if (checkBreakPage.Item1)
                    concatenateLetters = checkBreakPage.Item2;
                else
                {
                    if (concatenateLetters == "")
                        startLetter = true;
                    if (originalText[i] == '!' || originalText[i] == '.' || originalText[i] == '?')
                    {
                        concatenateLetters += originalText[i];
                        List<string> retorno = ComumExceptions(originalText, concatenateLetters, concatenateSentences, i);
                        concatenateLetters = retorno[0];
                        concatenateSentences = retorno[1];
                    }
                    else if (!startLetter)
                    {
                        concatenateLetters += originalText[i];
                    }
                    else
                    {
                        if (!(originalText[i] == ' '))
                            concatenateLetters += originalText[i];
                        startLetter = false;
                    }
                }
            }

            return concatenateSentences;
        }

        public string SepareteSentencesGermany(string originalText)
        {
            string concatenateSentences = "";
            string concatenateLetters = "";
            bool startLetter = false;
            for (int i = 0; i < originalText.Length; i++)
            {
                Tuple<bool, string> checkBreakPage = CheckBreakPage(originalText[i], concatenateLetters);
                if (checkBreakPage.Item1)
                    concatenateLetters = checkBreakPage.Item2;
                else
                {
                    if (concatenateLetters == "")
                        startLetter = true;
                    if (originalText[i] == '!' || originalText[i] == '.' || originalText[i] == '?')
                    {
                        concatenateLetters += originalText[i];
                        List<string> retorno = GermanyException(originalText, concatenateLetters, concatenateSentences, i);
                        concatenateLetters = retorno[0];
                        concatenateSentences = retorno[1];
                    }
                    else if (!startLetter)
                    {
                        concatenateLetters += originalText[i];
                    }
                    else
                    {
                        if (!(originalText[i] == ' '))
                            concatenateLetters += originalText[i];
                        startLetter = false;
                    }
                }
            }

            return concatenateSentences;
        }

        public List<string> GermanyException(string originalText,string concatenateLetters, string concatenateSentences, int i)
        {
            if (concatenateLetters.Count() >= 4)
            {
                string exceptionGermany = originalText[i - 3].ToString() + originalText[i - 2].ToString() + originalText[i - 1].ToString() + originalText[i].ToString();
                if (!(exceptionGermany == "bzw."))
                {
                    List<string> retorno = ComumExceptions(originalText, concatenateLetters, concatenateSentences, i);
                    concatenateLetters = retorno[0];
                    concatenateSentences = retorno[1];
                }
            }
            else
            {
                List<string> retorno = ComumExceptions(originalText, concatenateLetters, concatenateSentences, i);
                concatenateLetters = retorno[0];
                concatenateSentences = retorno[1];
            }

            return new List<string> { concatenateLetters, concatenateSentences };
        }

        public bool CheckDoctor(string originalText, string concatenateLetters, string concatenateSentences, int i)
        {
            string exceptionDoctor = "";
            if (concatenateLetters.Count() >= 3)
            {
                exceptionDoctor = originalText[i - 2].ToString() + originalText[i - 1].ToString() + originalText[i].ToString();
            }
            return exceptionDoctor.ToUpper() != "DR.";
        }

        public List<string> ComumExceptions(string originalText, string concatenateLetters, string concatenateSentences, int i)
        {
            
             if (concatenateLetters.Count() >= 2 && CheckDoctor(originalText, concatenateLetters, concatenateSentences, i))
            {
                string exceptionComum = "";
                string exceptionComum2 = "";
                if (originalText.Count() > i +1)
                    exceptionComum = originalText[i + 1].ToString() + originalText[i].ToString();
                if (i - 1 >= 0)
                    exceptionComum2 = originalText[i - 1].ToString() + originalText[i].ToString();
                if (!(exceptionComum == "..") && !(exceptionComum2 == ".."))
                {
                    if (concatenateLetters.Count() > 3)
                    {
                        if (concatenateLetters[0] == ' ')
                        {
                            string newJunction = "";
                            for (int y = 1; y < concatenateLetters.Count(); y++)
                            {
                                newJunction += concatenateLetters[y];
                            }
                            concatenateLetters = newJunction;
                        }
                        concatenateSentences += "*" + concatenateLetters;
                        concatenateLetters = "";
                    }
                }
            }
            
            return new List<string> { concatenateLetters, concatenateSentences };
        }

        public DataTable CarregaView(string ConcatenatedStrings,string[] Sentences, bool sortBySequence = false)
        {
            DataTable table = new DataTable();
            DataColumn column;
            DataRow row;

            // Create new DataColumn, set DataType,
            // ColumnName and add to DataTable.    
            column = new DataColumn();
            column.DataType = Type.GetType("System.Int32");
            column.ColumnName = "Number of Characters";
            column.AutoIncrement = false;
            column.ReadOnly = true;
            // Add the Column to the DataColumnCollection.
            table.Columns.Add(column);

            // Create second column.
            column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Sentence";
            column.AutoIncrement = false;
            column.Caption = "Sentence";
            column.ReadOnly = true;
            // Add the column to the table.
            table.Columns.Add(column);

            if(Sentences == null)
                Sentences = ConcatenatedStrings.Split('*');

            List<string> listSentences = new List<string>();
            for (int i = 0; i < Sentences.Length; i++)
            {
                if(Sentences[i] != "")
                    listSentences.Add(Sentences[i]);
            }

            if (!sortBySequence) 
            { 
                listSentences = listSentences.OrderByDescending(o => o.Length).ToList();
            }

            foreach (string sentence in listSentences)
            {
                row = table.NewRow();
                row["Number of Characters"] = sentence.Length.ToString();
                row["Sentence"] = sentence;
                table.Rows.Add(row);
            }
           
            return table;
        }

        public string EditRules(int typeText)
        {
            string rules;
            rules = typeText == 0 ? "Spanish" : typeText == 1 ? "English/Portuguese" : "Germany";
            rules += " Rules";

            return rules;
        }
    }
}
