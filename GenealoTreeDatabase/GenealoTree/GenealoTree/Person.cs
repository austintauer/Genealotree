using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenealoTree
{
    class Person : EventArgs
    {
        public string firstName { get; set; }
        public string middleName { get; set; }
        public string lastName { get; set; }
        public string sex { get; set; }
        public string profilePicturePath { get; set; }
        public string birthPlace { get; set; }
        public string deathPlace { get; set; }
        public string burialPlace { get; set; }
        public string cemetery { get; set; }
        public string birthCertificateNumber { get; set; }
        public string deathCertificateNumber { get; set; }
        public string socialSecurityNumber { get; set; }
        public string causeOfDeath { get; set; }

        public string[] militaryService;
        public string[] profession;
        public string[] notes;
        public string[] questions;

        public string birthDate { get; set; }
        public string deathDate { get; set; }
        public string burialDate{ get; set; }




public Person()
        {
            firstName = middleName = lastName = birthPlace = deathPlace = burialPlace = cemetery =
            birthCertificateNumber = deathCertificateNumber = socialSecurityNumber = causeOfDeath = "Austin";
            sex = null;

            profilePicturePath = @"../../Images/banana-cat.png";
            birthDate = "01011990";
            deathDate = "02021852";
            burialDate = "05052036";
        

            militaryService = new string[]{ "military service" };
            profession = new string[] { "profession" };
            notes = new string[] { "notes" };
            questions = new string[] { "questions" };
        }
public Person(string fname, string mname, string lname, string s, string birth, string death, string burial, string graveyard, string bcNum, string dcNum, string ssNum, string cod, string dob, string dod, string doburial)
        {
            firstName = fname;
            middleName = mname;
            lastName = lname;
            s = sex;
            birthPlace = birth;
            deathPlace = death;
            burialPlace = burial;
            cemetery = graveyard;
            birthCertificateNumber = bcNum;
            deathCertificateNumber = dcNum;
            socialSecurityNumber = ssNum;
            causeOfDeath = cod;
            birthDate = dob;
            deathDate = dod;
            burialDate = doburial;

            profilePicturePath = @"../../Images/banana-cat.png";
            militaryService = new String[] { "military service" };
            profession = new String[] { "profession" };
        }
    }
}
