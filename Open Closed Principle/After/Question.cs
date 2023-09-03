using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Open_Closed_Principle.after
{
    public abstract class Question
    {
        public string Title { get; set; }
        public int Mark { get; set; }
        public abstract void Print();
    }

    public class WHQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
            Console.WriteLine("  _____________________________");
        }
    }

    public class TFQuestion : Question
    {
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            Console.WriteLine("  1. T");
            Console.WriteLine("  2. F");
        }
    }
    public class MultiChoicesQuestion : Question
    {
        public List<string> Solutions { get; set; } =new List<string>();
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            foreach (var ans in Solutions)
            {
                Console.WriteLine($"  {ans}");
            }
        }
    }
    public class MatchQuestion : Question
    {
        public Dictionary<string,string> Solutions { get; set; } = new Dictionary<string, string>();
        public override void Print()
        {
            Console.WriteLine($"{Title} [{Mark}]");
            foreach (var ans in Solutions)
            {
                Console.WriteLine($"  {ans}");
            }
        }
    }
}
