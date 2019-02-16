using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment24
{
    public class Order
    {
        public int OrderId { get; set; }
        public string ItemName { get; set; }
        public DateTime OrderDate { get; set; }
        public int Quantity { get; set; }

        public Order()
        {

        }
        public Order(int OrderId, string ItemName, string OrderDate, int Quantity)
        {
            this.OrderId = OrderId;
            this.ItemName = ItemName;
            this.OrderDate = DateTime.ParseExact(OrderDate, "yyyy-MM-dd HH:mm:ss,fff",
                                       System.Globalization.CultureInfo.InvariantCulture);
            this.Quantity = Quantity;
        }
        public override string ToString()
        {
            return "Order ID " + this.OrderId + " Item Name " + this.ItemName + " Order Date " + this.OrderDate.Date.ToString("dd/MM/yyyy") + " Quantity " + this.Quantity;
        }
    }
}
