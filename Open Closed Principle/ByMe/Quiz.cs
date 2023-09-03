using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open_Closed_Principle.ByMe
{
    public class Quiz
    {
        public List<Questions> _questions { get; }
        public Quiz(List<Questions> questions)
        {
            this._questions = questions;
        }
        public void Print()
        {
            foreach (var q in _questions)
            {
                q.Print();
            }
        }
    }
}
