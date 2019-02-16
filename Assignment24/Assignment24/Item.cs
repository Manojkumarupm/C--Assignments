using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
   // item name and  price
    public class Item
    {
        public string ItemName { get; set; }
        public double Price { get; set; }
        public Item()
        {

        }
        public Item(string itemName,double price)
        {
            this.ItemName = itemName;
            this.Price = price;
        }
    }
}
