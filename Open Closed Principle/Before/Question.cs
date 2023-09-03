using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Open_Closed_Principle.Before
{
    public class Question
    {
        public string Title { get; set; }
        public QuestionType QuestionTypee { get; set; }
        public int Mark { get; set; }
        public List<string> Solutions { get; set; }
    }
}
