using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace princip3
{
    public class Order
    {
        public int orderNum { get; set;}
        public List<OrderItem> orderItems { get; set;}
        public double totalPrice { get; set;}

        public Order(int counter)
        {
            this.orderNum = counter;
            this.orderItems = new List<OrderItem>();
            this.totalPrice = 0;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            orderItems.Add(orderItem);
            totalPrice += orderItem.OrderItemPrice();
        }

        public double TotalOrderPrice()
        {
            return totalPrice;
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"---------ORDER: {orderNum} -------");
            Console.WriteLine("ITEMS:");
            foreach(var orderItem in orderItems)
            {
                orderItem.DisplayOrderItem();
            }
            Console.WriteLine($"TOTAL ORDER PRICE: {totalPrice}");
            
            Console.WriteLine("---------------------");
            
        }
    }
}
