using princip3.Coffes;
using princip3.Toppings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace princip3
{
    public class OrderItem
    {
        public Coffe Item { get; set; }
        public int Quantity {get; set; }
        public List<Topping> Toppings { get; set; }

        public OrderItem(Coffe item)
        {
            Item = item;
            Quantity = 0;
            Toppings = new List<Topping>();
        }


        public void SetQauntity(int quantity)
        {
            Quantity = quantity;
            Console.WriteLine($"Quantity set at: {quantity}");
        }

        public void AddTopping(Topping topping)
        {
            Toppings.Add(topping);
            Console.WriteLine("Topping added");
        }

        public double OrderItemPrice()
        {
            double toppingsPrice = 0;
            foreach(var topping in Toppings)
            {
                toppingsPrice += topping.Price;
            }

            return (Item.GetPrice() + toppingsPrice) * Quantity;
        }

        public void DisplayOrderItem()
        {
            Console.WriteLine();
            Item.DisplayCoffe();
            Console.WriteLine($"QUANTITY: {Quantity}");
            if(Toppings.Count > 0)
            {
                Console.WriteLine("TOPINGS:");
                foreach(var topping in Toppings)
                {
                topping.DisplayTopping();
                }

            }
            Console.WriteLine($"TOTALPRICE: {OrderItemPrice()}");
            Console.WriteLine();
        }
    }
}
