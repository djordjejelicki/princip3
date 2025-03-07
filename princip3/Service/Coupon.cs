using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace princip3.Service
{
    public class Coupon : ServiceType
    {
        public Coupon() : base(5)
        {
        }

        public override void DisplayService(double totalPrice)
        {
            double couponPrice = totalPrice * (ServicePercentage / 100);
            Console.WriteLine($"COUPON discount on price is: {couponPrice}");

        }

        public override double ServicePrice(double totalPrice)
        {
            double newPrice = totalPrice - (totalPrice * (ServicePercentage / 100));
            return newPrice;
        }
    }
}
