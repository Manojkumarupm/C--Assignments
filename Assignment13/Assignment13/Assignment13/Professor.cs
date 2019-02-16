using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    public class Professor : Person
    {
        public int bookPublished { get; set; }
        public Professor()
            : base()
        {

        }
        public Professor(string name, int bookPublished)
            : base(name)
        {
            this.bookPublished = bookPublished;
        }
        public void print()
        {
            Console.WriteLine(Name + " of the Professor who Published " + bookPublished + " books");
        }
        public override bool isOutstanding()
        {
            bool Result = false;
            if (bookPublished >= 4)
            {
                Result = true;
            }
            else
                Result = false;
            return Result;
        }
    }
}
