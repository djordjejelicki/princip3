using princip3.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace princip3
{
    public class Order
    {
        public int OrderNum { get; set; }
        public List<OrderItem> OrderItems { get; set; } 
        public ServiceType ServiceType { get; set; }
        public double TotalPrice { get; set; }

        public Order(int counter)
        {
            this.OrderNum = counter;
            this.OrderItems = new List<OrderItem>();
            this.TotalPrice = 0;
            
        }

        public void AddServiceType(ServiceType serviceType)
        {
            ServiceType = serviceType;
        }

        public void AddOrderItem(OrderItem orderItem)
        {
            OrderItems.Add(orderItem);
            TotalPrice += orderItem.OrderItemPrice();
        }

        public double TotalOrderPrice()
        {
            
            double totalOrderPriceService = ServiceType.ServicePrice(TotalPrice);
            return totalOrderPriceService;
        }

        public void DisplayOrder()
        {
            Console.WriteLine($"---------ORDER: {OrderNum} -------");
            Console.WriteLine("ITEMS:");
            foreach(var orderItem in OrderItems)
            {
                orderItem.DisplayOrderItem();
            }
            ServiceType.DisplayService(TotalPrice);
            Console.WriteLine($"TOTAL ORDER PRICE: {TotalPrice}");
            Console.WriteLine($"TOTAL ORDER PRICE with service: {TotalOrderPrice()}");
            
            Console.WriteLine("---------------------");
            
        }
    }
}
