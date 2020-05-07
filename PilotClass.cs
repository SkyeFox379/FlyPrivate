using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyPrivate
{
    class Pilot
    {
        private string _fName;
        private string _lName;
        private int _age;


        public string Fname
        {
            get
            {
                return _fName;
            }

            set
            {
                this._fName = value;
            }
        }

        public string Lname
        {
            get
            {
                return _lName;
            }

            set
            {
                this._lName = value;
            }
        }

        public int age
        {
            get
            {
                return _age;
            }

            set
            {
                this._age = value;
            }
        }


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
        public Pilot(string Fname, string Lname, int age, Certifications c)
        {
            pilotCertifications = new List<Certifications>();
            this.Fname = Fname;
            this.Lname = Lname;
            this.age = age;
            pilotCertifications.Add(c);
        }

    }
}
