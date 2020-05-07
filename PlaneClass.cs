using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPrivate
{
    class Plane : Aircraft
    {
        
        //Constructor
        public Plane(int fuel, int milesPerGallon, int speed, Certifications cert, int seats, double rent)
        {
            maxFuel = fuel;
            MPG = milesPerGallon;
            speedMPH = speed;
            certRequiredToFly = cert;
            AvailableSeats = seats;
            costToRentPerHour = rent;
        }

        public override string AircraftInfo()
        {
            string info;
            info = "You will be traveling on a plane";
            return info;
        }
    }
}
