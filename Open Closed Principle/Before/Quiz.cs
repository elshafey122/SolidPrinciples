using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.Before
{
    public class Quiz
    {
        public List<Question> _questions { get; }
        public Quiz(List<Question> questions)
        {
            _questions = questions;
        }
        public void print()
        {
            foreach (var q in _questions)
            {

                Console.WriteLine($"{q.Title} [{q.Mark}]");
                switch (q.QuestionTypee)
                {
                    case QuestionType.Wh:
                        Console.WriteLine("  _____________________________");
                        Console.WriteLine("  _____________________________");
                        Console.WriteLine("  _____________________________");
                        Console.WriteLine("  _____________________________");
                        break;
                    case QuestionType.TF:
                        Console.WriteLine("  1. T");
                        Console.WriteLine("  2. F");
                        break;
                    case QuestionType.MultiChoices:
                        foreach (var ans in q.Solutions)
                        {
                            Console.WriteLine($"  {ans}");
                        }
                        break;
                    case QuestionType.Match:
                        foreach (var ans in q.Solutions)
                        {
                            Console.WriteLine($"  {ans}");
                        }
                        break;
                    default:
                        break;
                }
            }
        }
    }
}
