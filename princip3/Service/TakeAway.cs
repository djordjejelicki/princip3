using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace princip3.Service
{
    public class TakeAway : ServiceType
    {
        public TakeAway() : base(2)
        {
        }

        public override void DisplayService(double totalPrice)
        {
            if (totalPrice > 750)
            {
                Console.WriteLine();
                Console.WriteLine("Order is bigger than 750 , no charge for take away service");
                Console.WriteLine();
            }
            else
            {
                double takeAwayprice = totalPrice * (ServicePercentage / 100);
                Console.WriteLine();
                Console.WriteLine($"Price for take away is : {takeAwayprice}");
                Console.WriteLine();
            }
                
        }

        public override double ServicePrice(double totalPrice)
        {
            if(totalPrice < 750)
            {
               return totalPrice + (totalPrice * (ServicePercentage / 100));
                

            }
            else
            {
                return totalPrice;
            }
        }
    }
}
