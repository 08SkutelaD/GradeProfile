using System;

namespace GradeSystem
{
    public class Grade
    {
        private string module;
        private string assignment;
        private int mark;
        private decimal weight;

        public string Module
        {
            get { return module; }
        }
        public int Mark
        {
            get { return mark; }
        }
        public decimal Weight
        {
            get { return weight; }
        }

        public Grade(string module, string assignment, int mark, decimal weight)
        {
            this.module = module;
            this.assignment = assignment;
            this.mark = mark;
            this.weight = weight;
        }

        public void DisplayGradeDetails()
        {
            Console.WriteLine(module + " (" + assignment + ")");
            Console.WriteLine("Mark: " + mark + "%");
            Console.WriteLine("Weight: " + (weight * 100) + "%");
        }
    }
}