using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPrivate
{
    class Customer
    {
        public string name;
        

        public Customer(string name)
        {
            this.name = name;
        }

        public double CostofFlight(double priceToFlyIntoCity, double rentCost, double distanceTraveled)
        {                                    
            double total = priceToFlyIntoCity + rentCost + (distanceTraveled * 1.25);//$1.25 per mile flown

            return total;
        }
    }
}
