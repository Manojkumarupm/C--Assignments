using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{

    class Program
    {

        delegate void ListCollectionAdd(int Number);
        delegate void DisplayItemDivisibleByThree();
        static void Main(string[] args)
        {

            #region Part 1
            Console.WriteLine("Console Program Assignment 12 Part 1 - Array and Printing the same in Console");
            DynamicArray da = new DynamicArray();
            da.CustomArray = new int[3, 3] { { 5, 8, 9 }, { 7, 8, 9 }, { 1, 2, 3 } };

            da.Display();
            Console.WriteLine();
            #endregion

            #region Part 2
            Console.WriteLine("Console Program Assignment 12 Part 2 Multiple Inheritance Concept Calculator Program");

            MultipleInheritance mi = new MultipleInheritance();
            Console.WriteLine("Add 5 + 8 =" + mi.Add(5, 8));
            Console.WriteLine("Division 8 / 4 = " + mi.Division(8, 4));
            Console.WriteLine("Multiplication 10 * 2 = " + mi.Multiplication(10, 2));
            Console.WriteLine("Subtract 240 -5 =" + mi.Subtract(240, 5));

            Console.WriteLine("");
            #endregion


            #region Part3
            Console.WriteLine("Console Program Assignment 12 Part 3 Delegates and Lamda Expression");

            CollectionExcercise ce = new CollectionExcercise();

            ListCollectionAdd lc = new ListCollectionAdd(ce.AddCollectionItems);

            DisplayItemDivisibleByThree dli = new DisplayItemDivisibleByThree(ce.DisplayCollectionItems);
            lc(5);
            lc(9);
            lc(12);
            lc(6);
            lc(24);
            lc(2);
            dli();
            Console.WriteLine("Using Delegate Results ");
            dli = new DisplayItemDivisibleByThree(ce.DisplayCollectionItemsDivisibleByThree);

            List<int> list = ce.CollectionList.FindAll(x => (x % 3) == 0);
            Console.Write("Using Lamda Results ");
            foreach (int i in list)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();

            #endregion

            #region "Part 4"

            string[] emailAddresses = { "manoj.kumar@iiht.com", "m.p@server1.iiht.com",
                                  "manoj@mk1.iiht.com", "m.@server1.iiht.com",
                                  "p@iiht.com9", "pm#internal@iiht.com",
                                  "m_9@[129.126.118.1]", "j..s@iiht.com",
                                  "ps*@iiht.com", "js@iiht..com",
                                  "js@iiht.com9", "j.s@server1.iiht.com",
                                   "\"j\\\"s\\\"\"@iiht.com", "js@iiht.中国" };

            foreach (var emailAddress in emailAddresses)
            {
                if (emailAddress.IsEmail())
                    Console.WriteLine("Valid: {0}", emailAddress);
                else
                    Console.WriteLine("Invalid: {0}", emailAddress);
            }

            #endregion "Part 4"

            Console.ReadKey();
        }
    }
}
