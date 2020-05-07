using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyPrivate
{

    public enum Certifications
    {
        privateCert,
        dualEngineCert,
        jetCert
    }



    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());


            //Things to Add in Future
                //A schedule for each pilot so that the dates entered in the application form 
                //can be compared to a pilot's schedule to see if a pilot is available for that date and time range
            
                //The day drop down box is affected by the month selected in the month drop down box

                //Logic to determin if a plane/jet is being used so that the system can assign a different aircraft to the flight

                //work on getting time range working instead of earliest time, requires getting a schedule working first

                //could also look into offering the customer an aircraft that has more seats than needed if the only
                //reason why the flight isn't avaialbe is because all the aircrafts with the amount of seats they
                //specify is already being used/are unavailable
        }
    }
}
