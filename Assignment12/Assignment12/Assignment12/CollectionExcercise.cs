using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment12
{
    class CollectionExcercise
    {
        public List<int> CollectionList;
        
        public CollectionExcercise()
        {
            CollectionList = new List<int>();
        }
            
        public void AddCollectionItems(int Value)
        {
            CollectionList.Add(Value);
        }
        public void DisplayCollectionItems()
        {
            Console.Write("Collection List Items : ");
            foreach(int i in CollectionList)
            {
                
                Console.Write(" "+i);
            }
            Console.WriteLine();
        }
        public void DisplayCollectionItemsDivisibleByThree()
        {
            Console.Write("COllection List Items : ");
            foreach (int i in CollectionList)
            {
                if (i % 3 == 0)
                    Console.Write(" " + i);
            }
            Console.WriteLine();
        }
    }
}
