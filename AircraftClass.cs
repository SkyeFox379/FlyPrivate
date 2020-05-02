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
        public float costToRentPerHour
        {
            get
            {
                return costToRentPerHour;
            }
            set
            {
                this.costToRentPerHour = (float)(value) * (float)(1.07);
            }
        }

        //put this in constructor instead of a setter so can only be set once
        public Certifications certRequiredToFly
        {
            get
            {
                return certRequiredToFly;
            }
        }


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
        
        public int MaxTravelDistance()
        {
            return MPG * maxFuel;
        }

        public float TravelTime(int miles)
        {
            return (miles / speedMPH);
        }

        public double CalculateTravelFuel(int miles)
        {
            double total = 0;
            return total;
        }

        //Constructor
        //public Aircraft(int fuel, int milesPerGallon, int speed, Certifications cert, int seats)
        //{
            //maxFuel = fuel;
            //MPG = milesPerGallon;
            //speedMPH = speed;
            //certRequiredToFly = cert;
            //AvailableSeats = seats;
        //}

    }
}
