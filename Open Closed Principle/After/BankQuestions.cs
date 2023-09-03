using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.after
{
    public class BankQuestions
    {
        public static List<Question> Generate()
        {
            return new List<Question>
            {
                new WHQuestion()
                {
                    Title = "What are the four pillars of OOP?",
                    Mark = 8,
                },
                new MultiChoicesQuestion()
                {
                    Title = "Which of the following are value types?",
                    Mark = 6,
                    Solutions = new List<string>
                    {
                        "A: Integer",
                        "B: Array",
                        "C: Single",
                        "D: String",
                        "E: Long",
                    }
                },
                new TFQuestion()
                {
                     Title = "Earth is Bigger than sun?",
                     Mark = 4,
                },
                new MultiChoicesQuestion()
                {
                    Title = "Which of the following is an 8-byte Integer?",
                    Mark = 6,
                    Solutions=new List<string>
                    {
                       "A.  Char",
                       "B.  Long",
                       "C.  Short",
                       "D.  Byte",
                       "E.  Integer"
                    }
                },
                new MatchQuestion()
                {
                     Title = "match the queestion with answer",
                     Mark = 4,
                    Solutions = new Dictionary<string, string>
                    {
                        {"a : ali is a"    , "a:doctor"},
                        {"b : ahmed is a"  , "b:doctor"},
                        {"c : salah is a"  , "c:doctor"},
                        {"d : adel is a"   , "d:doctor"}
                    }
                }
            };
        }
    }
}
