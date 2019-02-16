using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    public class DynamicArray
    {
        //Data Members
        public int[,] CustomArray;

        public DynamicArray()
        {
            CustomArray = new int[3, 3]; // Define default size as 3 * 3
        }
        public void Display()
        {
            Console.WriteLine("Printing the Given Array in Console");

            for (int i = 0; i <=CustomArray.Rank; i++)
            {
                Console.WriteLine("");
                for (int j = 0; j <= CustomArray.Rank; j++)
                {
                    Console.Write("\t" + CustomArray[i, j]);
                }

            }

        }
    }
}
