using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.after
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
                q.Print();
            }
        }
    }
}
