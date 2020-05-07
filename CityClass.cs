using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPrivate
{
    class City
    {
        private double _cost;


        public double costToFlyInto
        {
            get
            {
                return _cost;
            }

            set
            {
                this._cost = value;
            }
        }

        //each degree is 69 miles apart
        public int latitude;
        //each degree is 53 miles apart
        public int longitude;



        //Calculate the distance between two cities
        public double DistanceBetween(City destination)
        {
            int miles = 0;
            int lon = System.Math.Abs(this.longitude - destination.longitude);
            int lat = System.Math.Abs(this.latitude - destination.latitude);
            miles = miles + lon * 53;
            miles = miles + lat * 69;
            return miles;
        }

        //Constructor
        public City(int costFlyInto, int lat, int lon)
        {
            costToFlyInto = costFlyInto;
            latitude = lat;
            longitude = lon;
        }
    }
}
