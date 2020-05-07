using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPrivate
{
    class Aircraft
    {
        private int _maxFuel;
        private int _MPG;
        private int _speedMPH;


        public int maxFuel
        {
            get
            {
                return _maxFuel;
            }

            set
            {
                this._maxFuel = value;
            }
        }

        public int MPG
        {
            get
            {
                return _MPG;
            }

            set
            {
                this._MPG = value;
            }
        }

        public int speedMPH
        {
            get
            {
                return _speedMPH;
            }

            set
            {
                this._speedMPH = value;
            }
        }

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
        
        public Certifications certRequiredToFly { get; set; }

        public int AvailableSeats { get; set; }
        
        //polymorphism example
        //tells the user what aircraft they will be flying on, appears on the success form
        public virtual string AircraftInfo()
        {
            string info;
            info = "You will be flying on a <placeholder>";
            return info;
        }

    }
}
