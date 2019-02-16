using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    public abstract class  Person
    {
        public String Name { get; set; }
        public Person()
        {
            Name = string.Empty;
        }
        public Person(string name)
        {
            Name = name;
        }
        public string getName()
        {
            return Name;
        }
        public void setName(string name)
        {
            Name = name;
        }
        public abstract bool isOutstanding();
         
    }
}
