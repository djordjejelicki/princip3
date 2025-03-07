using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace princip3.Service
{
    public abstract class ServiceType
    {
        
        public double ServicePercentage { get; set; }
        

        public ServiceType(int servicePercentage)
        {
            ServicePercentage = servicePercentage;
        }

        public abstract double ServicePrice(double totalPrice);

        public abstract void DisplayService(double totalPrice);
      
    }
}
