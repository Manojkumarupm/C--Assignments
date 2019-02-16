using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    public class Student : Person
    {
        double Percentage;
        public Student()
            : base()
        {

        }
        public Student(string name, double Percentage)
            : base(name)
        {
            this.Percentage = Percentage;
        }
        public void display()
        {
            Console.WriteLine(Name + " of the Student who got " + Percentage + " Percentage");
        }
        public override bool isOutstanding()
        {
            bool Result = false;
            if (Percentage >= 85)
            {
                Result = true;
            }
            else
                Result = false;
            return Result;
        }
    }
}
