using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace princip3.Toppings
{
    public abstract class Topping
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Topping(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public void DisplayTopping()
        {
            Console.WriteLine($"NAME: {Name}  PRICE per unit: {Price}");
        }
    }
}
