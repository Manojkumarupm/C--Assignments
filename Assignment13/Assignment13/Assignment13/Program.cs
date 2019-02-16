using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment13
{
    class Program
    {
        static void Main(string[] args)
        {
            Person[] person = new Person[5];
            person[0] = new Professor("Manoj", 6);
            person[1] = new Professor("Kumar", 4);
            person[2] = new Professor("Mani", 2);
            person[3] = new Student("Raja", 89);
            person[4] = new Student("Prabhu", 83);

            for (int i = 0; i < person.Length; i++)
            {
                if (person[i].GetType().Name.Equals("Student"))
                {
                    if ((person[i] as Student).isOutstanding())
                    {
                        (person[i] as Student).display();
                    }

                }
                if (person[i].GetType().Name.Equals("Professor"))
                {
                    if ((person[i] as Professor).isOutstanding())
                    {
                        (person[i] as Professor).print();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
