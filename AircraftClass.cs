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
        public int speedMPH;
        public double costToRentPerHour;
        public double rent
        {
            get
            {
                return costToRentPerHour;
            }
            set
            {
                this.costToRentPerHour = (double)(value) * (double)(1.07);
            }
        }
        //put this in constructor instead of a setter so can only be set once
        public Certifications certRequiredToFly { get; set; }


        //seats may go under maintanance so we need to be able to change the number of available seats
        public int AvailableSeats { get; set; }
        

    }
}
