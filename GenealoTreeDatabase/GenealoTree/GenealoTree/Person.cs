using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenealoTree
{
    class Person
    {
        public string firstName, middleName, lastName, sex, profilePicturePath, birthPlace, deathPlace, burialPlace, cemetery,
            birthCertificateNumber, deathCertificateNumber, socialSecurityNumber, causeOfDeath;

        public string[] militaryService, profession;

        DateTime birthDate, deathDate, burialDate;




        public Person()
        {
            firstName = middleName = lastName = sex = birthPlace = deathPlace = burialPlace = cemetery =
            birthCertificateNumber = deathCertificateNumber = socialSecurityNumber = causeOfDeath = "Austin";

            profilePicturePath = @"../../banana-cat.png";

           // profilePicturePath = "C:\\Users\\taylor.ruhoff\\Documents\\GitHub\\Genealotree\\GenealoTreeDatabase\\GenealoTree\\GenealoTree\\banana-cat.png";

            birthDate = deathDate = burialDate = new DateTime();

            militaryService = new String[]{ "adfdkljasdf" };
            profession = new String[] { "profession"};



        }
    }
}
