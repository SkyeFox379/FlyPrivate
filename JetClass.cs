using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPrivate
{
    class Jet : Aircraft
    {
        //Constructor
        public Jet(int fuel, int milesPerGallon, int speed, Certifications cert, int seats, double rent)
        {
            maxFuel = fuel;
            MPG = milesPerGallon;
            speedMPH = speed;
            certRequiredToFly = cert;
            AvailableSeats = seats;
            costToRentPerHour = rent;
        }
    }
}
