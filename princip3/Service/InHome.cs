using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace princip3.Service
{
    public class InHome : ServiceType
    {
        public InHome() : base(0)
        {
        }

        public override void DisplayService(double totalPrice)
        {
            Console.WriteLine();
            Console.WriteLine("There is now charge for in home , enjoy");
            Console.WriteLine();
        }

        public override double ServicePrice(double totalPrice)
        {
            return totalPrice;
        }
    }
}
