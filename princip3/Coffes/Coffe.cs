using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace princip3.Coffes
{
    public abstract class Coffe
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }

        public Coffe(string name,string type, double price)
        {
            Name = name;
            Type = type;
            Price = price;
        }

        public double GetPrice()
        {

            if (Type == "R")
            {
                return Price;
            }
            else
            {
                return Price * 1.7;
            }
        }

        public void DisplayCoffe()
        {
            Console.WriteLine($"NAME: {Name}  SIZE: {Type}  PRICE: {GetPrice()}");
        }

    }
}
