using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPrivate
{
    class Aircraft
    {
        public int maxFuel;
        public int MPG; //miles per gallon

        //seats may go under maintanance so we need to be able to change the number of available seats
        public int AvailableSeats
        {
            get
            {
                return AvailableSeats;
            }

            set
            {
                this.AvailableSeats = value;
            }
        }
        
        public double CalculateTravelFuel(int miles)
        {
            double total = 0;
            return total;
        }

    }
}
