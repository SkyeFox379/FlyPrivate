using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyPrivate
{
    public partial class Form1 : Form
    {
        Dictionary<string, City> Cities = new Dictionary<string, City>();
        List<List<Pilot>> Pilots = new List<List<Pilot>>();
        List<List<Plane>> Planes = new List<List<Plane>>();
        List<List<Jet>> Jets = new List<List<Jet>>();

        public int RandomNum(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public Form1()
        {
            //Cities
            Cities.Add("Sioux Falls, SD", new City(35, 44, 98));
            Cities.Add("Aberdeen, SD", new City(15, 45, 99));
            Cities.Add("Madison, SD", new City(7, 44, 97));
            Cities.Add("Rapid City, SD", new City(65, 44, 103));


            //Pilots
            List<Pilot> Jet_Pilots = new List<Pilot>();
            Jet_Pilots.Add(new Pilot("Adam", "Dunn", 30, Certifications.jetCert));
            Jet_Pilots.Add(new Pilot("Sam", "Pik", 37, Certifications.jetCert));
            Jet_Pilots.Add(new Pilot("Tally", "Winheart", 26, Certifications.jetCert));
            Jet_Pilots.Add(new Pilot("Caitlyn", "Piltover", 40, Certifications.jetCert));
            Pilots.Add(Jet_Pilots);

            List<Pilot> Private_Pilots = new List<Pilot>();
            Private_Pilots.Add(new Pilot("Pam", "Layne", 31, Certifications.privateCert));
            Private_Pilots.Add(new Pilot("Annie", "Tibbers", 25, Certifications.privateCert));
            Private_Pilots.Add(new Pilot("Quinn", "Valor", 26, Certifications.privateCert));
            Private_Pilots.Add(new Pilot("Yorick", "Void", 25, Certifications.privateCert));
            Pilots.Add(Private_Pilots);

            List<Pilot> DuelE_Pilots = new List<Pilot>();
            DuelE_Pilots.Add(new Pilot("Tallon", "Arne", 30, Certifications.dualEngineCert));
            DuelE_Pilots.Add(new Pilot("Ahri", "Fox", 31, Certifications.dualEngineCert));
            DuelE_Pilots.Add(new Pilot("Zyra", "Plant", 34, Certifications.dualEngineCert));
            DuelE_Pilots.Add(new Pilot("Xerath", "Azir", 107, Certifications.dualEngineCert));
            Pilots.Add(DuelE_Pilots);


            //Planes (2 of each)
            List<Plane> One_Seat_Planes = new List<Plane>();
            One_Seat_Planes.Add(new Plane(45, 20, 125, Certifications.privateCert, 1, 25.15));
            One_Seat_Planes.Add(new Plane(65, 16, 145, Certifications.privateCert, 1, 25.15));
            Planes.Add(One_Seat_Planes);

            List<Plane> Two_Seat_Planes = new List<Plane>();
            Two_Seat_Planes.Add(new Plane(45, 11, 125, Certifications.dualEngineCert, 2, 36.16));
            Two_Seat_Planes.Add(new Plane(36, 12, 134, Certifications.privateCert, 2, 36.16));
            Planes.Add(Two_Seat_Planes);

            List<Plane> Three_Seat_Planes = new List<Plane>();
            Three_Seat_Planes.Add(new Plane(55, 10, 115, Certifications.privateCert, 3, 44.20));
            Three_Seat_Planes.Add(new Plane(45, 15, 125, Certifications.privateCert, 3, 44.20));
            Planes.Add(Three_Seat_Planes);

            List<Plane> Four_Seat_Planes = new List<Plane>();
            Four_Seat_Planes.Add(new Plane(45, 15, 125, Certifications.dualEngineCert, 4, 50));
            Four_Seat_Planes.Add(new Plane(45, 15, 125, Certifications.privateCert, 4, 50));
            Planes.Add(Four_Seat_Planes);

            List<Plane> Five_Seat_Planes = new List<Plane>();
            Five_Seat_Planes.Add(new Plane(45, 15, 125, Certifications.privateCert, 5, 65.30));
            Five_Seat_Planes.Add(new Plane(45, 15, 125, Certifications.dualEngineCert, 5, 65.30));
            Planes.Add(Five_Seat_Planes);


            //Jets (2 of each)
            List<Jet> Six_Seat_Jets = new List<Jet>();
            Six_Seat_Jets.Add(new Jet(45, 15, 150, Certifications.jetCert, 6, 78.30));
            Six_Seat_Jets.Add(new Jet(45, 17, 105, Certifications.jetCert, 6, 78.30));
            Jets.Add(Six_Seat_Jets);

            List<Jet> Seven_Seat_Jets = new List<Jet>();
            Seven_Seat_Jets.Add(new Jet(55, 15, 125, Certifications.jetCert, 7, 84.50));
            Seven_Seat_Jets.Add(new Jet(45, 15, 125, Certifications.jetCert, 7, 84.50));
            Jets.Add(Seven_Seat_Jets);

            List<Jet> Eight_Seat_Jets = new List<Jet>();
            Eight_Seat_Jets.Add(new Jet(45, 15, 120, Certifications.jetCert, 8, 94.50));
            Eight_Seat_Jets.Add(new Jet(65, 20, 125, Certifications.jetCert, 8, 94.50));
            Jets.Add(Eight_Seat_Jets);

            List<Jet> Nine_Seat_Jets = new List<Jet>();
            Nine_Seat_Jets.Add(new Jet(35, 21, 130, Certifications.jetCert, 9, 84.50));
            Nine_Seat_Jets.Add(new Jet(55, 14, 100, Certifications.jetCert, 9, 84.50));
            Jets.Add(Nine_Seat_Jets);

            List<Jet> Ten_Seat_Jets = new List<Jet>();
            Ten_Seat_Jets.Add(new Jet(65, 11, 125, Certifications.jetCert, 10, 110.50));
            Ten_Seat_Jets.Add(new Jet(45, 20, 125, Certifications.jetCert, 10, 110.50));
            Jets.Add(Ten_Seat_Jets);

            InitializeComponent();
        }

        private void SubmitBtn_Click(object sender, EventArgs e)
        {
            bool match = true;
            double price;
            int selectPilot;
            int selectCert;
            string info = "placeholder";

            Pilot Pilot_For_Trip = Pilots[0][0];

            String Start_City_txt = StartLocCB.Text;
            City Start_City = Cities[Start_City_txt];

            String End_City_txt = DestinationCB.Text;
            City End_City = Cities[End_City_txt];

            int People_Traveling = Int32.Parse(NumOfFlyersCB.Text);
            Plane Plane_For_Trip = Planes[0][0];
            Jet Jet_For_Trip = Jets[0][0];

            //Planes have 1-5 seats so assign a plane 
            if(People_Traveling <= 5)
            {
                //we need to initialize a plane to be able to call aircraftInfo method from the place class
                var p = new Plane(80, 20, 100, Certifications.privateCert, 2, 10);

                //we select a random pilot until we impliment a schedule
                selectPilot = RandomNum(1, 4);

                //this selects either a pilot with a private or dualE certification
                selectCert = RandomNum(1, 2);

                Pilot_For_Trip = Pilots[selectCert][selectPilot];

                Plane_For_Trip = Planes[People_Traveling - 1][0]; 
                
                //logic for determining if the plane is available goes here, if no planes with specified seats are available then increment people traveling

                info = p.AircraftInfo();
            }

            //More than 5 seats means they need a jet
            else
            {
                //we need to initialize a jet to be able to call aircraftInfo method from the jet class
                var j = new Jet(80, 20, 100, Certifications.jetCert, 2, 10);

                //we select a random pilot until we impliment a schedule 
                selectPilot = RandomNum(1, 4);
                Pilot_For_Trip = Pilots[0][selectPilot];

                //People_Traveling - 5 is so that we can index back to zero since People_Traveling is greater than 5
                Jet_For_Trip = Jets[People_Traveling - 5][0];

                info = j.AircraftInfo();
            }

            //brings up success form
            if (match == true)
            {
                var c = new Customer("name");
                double Rent_Cost = (People_Traveling <= 5 ? Plane_For_Trip.costToRentPerHour * (Start_City.DistanceBetween(End_City) / Plane_For_Trip.speedMPH) : Jet_For_Trip.costToRentPerHour * (Start_City.DistanceBetween(End_City) / Jet_For_Trip.speedMPH));
                price = c.CostofFlight(End_City.costToFlyInto, Rent_Cost, Start_City.DistanceBetween(End_City));
                this.Hide();
                SuccessForm sForm = new SuccessForm();

                //change placeholder info to match pricing and present a time
                //for now we give them the earliest time they specify
                string timeOfFlight = HourCB.Text + ":" + MinuteCB.Text + amORpmCB.Text;
                string dateOfFlight = SelectMonthCB.Text + " " + SelectDayCB.Text + ", " + SelectYearCB.Text;
                sForm.aircraftInfoLabel.Text = info;
                sForm.PlaceHolderPilot.Text = Pilot_For_Trip.Fname + " " + Pilot_For_Trip.Lname;
                sForm.TimePlaceholderLabel.Text = timeOfFlight;
                sForm.PlaceHolderDateLabel.Text = dateOfFlight;
                sForm.PricePlaceholderLabel.Text = "$" + Math.Round((double)price, 2);
                sForm.ShowDialog();

            }


            //brings up no flights found form
            if(match == false)
            {
                this.Hide();
                NoFlightsForm noneForm = new NoFlightsForm();
                noneForm.ShowDialog();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
