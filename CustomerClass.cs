using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPrivate
{
    class Customer
    {
        private string _name;
        public string name
        {
            get
            {
                return _name;
            }

            set
            {
                this._name = value;
            }
        }
        
        //constructor
        public Customer(string name)
        {
            this.name = name;
        }

        //this calculates the cost of flight based on price to fly into city, cost to rent the aircraft
        //and the distance between your start and end city
        public double CostofFlight(double priceToFlyIntoCity, double rentCost, double distanceTraveled)
        {                                    
            double total = priceToFlyIntoCity + rentCost + (distanceTraveled * 1.25);//$1.25 per mile flown

            return total;
        }
    }
}
