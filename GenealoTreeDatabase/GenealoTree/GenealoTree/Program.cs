﻿using System;
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

            int maxId = 0;
            Person person = null;
            List<Person> people = new List<Person>();
            foreach (string s in fileArray)
            {
                FileStream fs = File.Open(s, FileMode.Open, FileAccess.ReadWrite, FileShare.None);
                StreamReader sr = new StreamReader(fs);
                person = new Person();
                person.id = int.Parse(sr.ReadLine());
                if (person.id > maxId)  //find highest taken id
                {
                    maxId = person.id;
                }
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

                person.birthKnown = bool.Parse(sr.ReadLine());
                person.deathKnown = bool.Parse(sr.ReadLine());
                person.burialKnown = bool.Parse(sr.ReadLine());

                if (person.birthKnown)      //don't load if not known
                {
                    person.birthDate = DateTime.Parse(sr.ReadLine());
                }
                else
                {
                    sr.ReadLine();
                }
                if (person.deathKnown)
                {
                    person.deathDate = DateTime.Parse(sr.ReadLine());
                }
                else
                {
                    sr.ReadLine();
                }
                if (person.burialKnown)
                {
                    person.burialDate = DateTime.Parse(sr.ReadLine());
                }
                else
                {
                    sr.ReadLine();
                }
                
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
                    for (int i = 0; i + 1 < relTokens.Length; i = i + 2)
                    {
                        person.relationships.Add(new Relationship(int.Parse(relTokens[i + 1]), relTokens[i]));
                    }
                }

                people.Add(person);
                sr.Close();
                fs.Close();
            }

            Person.maxId = maxId;//set where new id's can start

            Application.Run(new WelcomeScreen(people));


            

        }
    }
}
