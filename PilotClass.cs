using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPrivate
{
    class Pilot
    {
        public string Fname;
        public string Lname;
        public int age;
        public List<Certifications> pilotCertifications;
        bool cert = false;

        public void addCert(Certifications c)
        {
            for (int i = 0; i < pilotCertifications.Count; i++)
            {
                if (pilotCertifications[i] == c)
                {
                    Console.WriteLine("This certification has already been listed");
                    cert = true;
                }
            }
            if(cert != true)
                pilotCertifications.Append(c);
            cert = false;
        }

        public void removeCert(Certifications c)
        {
            for (int i = 0; i < pilotCertifications.Count; i++)
            {
                if (pilotCertifications[i] == c)
                {
                    pilotCertifications.RemoveAt(i);
                }
            }
        }


        //Constructor
        public Pilot(string Fname, string Lname, int age, Certifications certification)
        {
            this.Fname = Fname;
            this.Lname = Lname;
            this.age = age;
            pilotCertifications.Add(certification);
        }

    }
}
