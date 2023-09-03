using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Before
{
    public class BankQuestions
    {
        public static List<Question> Generate()
        {
            return new List<Question>
            {
                new Question()
                {
                    Title = "What are the four pillars of OOP?",
                    Mark = 8,
                },
                new Question()
                {
                    Title = "Which of the following are value types?",
                    QuestionTypee = QuestionType.MultiChoices,
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
                new Question()
                {
                     Title = "Earth is Bigger than sun?",
                    QuestionTypee = QuestionType.TF,
                     Mark = 4,
                },
                new Question()
                {
                    Title = "Which of the following is an 8-byte Integer?",
                    QuestionTypee = QuestionType.MultiChoices,
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
                new Question()
                {
                     Title = "match the queestion with answer",
                    QuestionTypee = QuestionType.Match,
                     Mark = 4,
                    Solutions = new List<string>
                    {
                        $"a : ali is a               a:doctor",
                        $"b : ahmed is a             b:engineer",
                        $"c : salah is a             c:worker",
                        $"d : tamer is a             d:programmer",
                    }
                },
            };
        }
    }
}
