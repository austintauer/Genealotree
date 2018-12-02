using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenealoTree
{
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

            string[] fileArray = Directory.GetFiles(@"../../PersonFiles/");

            //FileStream fs = File.Open(@"../../PersonFiles/AustinTauer.gt", FileMode.Open, FileAccess.ReadWrite, FileShare.None);
            Person person = null;
            List<Person> people = new List<Person>();
            foreach (string s in fileArray)
            {
                FileStream fs = File.Open(s, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                StreamReader sr = new StreamReader(fs);
                person = new Person();
                person.id = int.Parse(sr.ReadLine());
                person.firstName = sr.ReadLine();
                person.middleName = sr.ReadLine();
                person.lastName = sr.ReadLine();
                person.sex = sr.ReadLine();
                person.profilePicturePath = sr.ReadLine();
                person.birthPlace = sr.ReadLine();
                person.deathPlace = sr.ReadLine();
                person.burialPlace = sr.ReadLine();
                person.cemetery = sr.ReadLine();
                person.socialSecurityNumber = sr.ReadLine();
                person.causeOfDeath = sr.ReadLine();
                person.birthCertificateNumber = sr.ReadLine();
                person.deathCertificateNumber = sr.ReadLine();
                person.dead = bool.Parse(sr.ReadLine());
                person.buried = bool.Parse(sr.ReadLine());

                string milTemp = sr.ReadLine();
                if (milTemp != null)
                {
                    string[] milTokens = milTemp.Split(',');
                    for (int i = 0; i < milTokens.Length; i++)
                    {
                        person.militaryService.Add(milTokens[i]);
                    }
                }

                string proTemp = sr.ReadLine();
                if (proTemp != null)
                {
                    string[] proTokens = proTemp.Split(',');
                    for (int i = 0; i < proTokens.Length; i++)
                    {
                        person.profession.Add(proTokens[i]);
                    }
                }

                string noTemp = sr.ReadLine();
                if (noTemp != null)
                {
                    string[] noTokens = noTemp.Split(',');
                    for (int i = 0; i < noTokens.Length; i++)
                    {
                        person.notes.Add(noTokens[i]);
                    }
                }

                string queTemp = sr.ReadLine();
                if (queTemp != null)
                {
                    string[] queTokens = queTemp.Split(',');
                    for (int i = 0; i < queTokens.Length; i++)
                    {
                        person.questions.Add(queTokens[i]);
                    }
                }

                string relTemp = sr.ReadLine();
                if (relTemp != null)
                {
                    string[] relTokens = relTemp.Split(',');
                    for (int i = 0; i < relTokens.Length; i = i + 2)
                    {
                        person.relationships.Add(new Relationship(int.Parse(relTokens[i + 1]), relTokens[i]));
                    }
                }

                people.Add(person);
            }
            //Application.Run(new RelationshipForm(people, person));


            //Application.Run(new PersonalInformationForm(people, person));
            //Application.Run(new AddModifyForm(people, person));
            //Application.Run(new SelectionViewForm(null));
            //Application.Run(new SelectionViewForm());
            Application.Run(new WelcomeScreen(people));
        }
    }
}
