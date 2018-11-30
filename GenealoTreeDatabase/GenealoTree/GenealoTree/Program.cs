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
                string relTemp = sr.ReadLine();
                string[] relTokens = relTemp.Split(' ');
                person.relationships.Add(new Relationship(int.Parse(relTokens[1]), relTokens[0]));


                people.Add(person);
            }
            //Application.Run(new RelationshipForm(people, person));


            //Application.Run(new PersonalInformationForm(people, person));
           Application.Run(new AddModifyForm(people, person));
            //Application.Run(new SelectionViewForm(null));
            //Application.Run(new SelectionViewForm());
            //Application.Run(new WelcomeScreen());
        }
    }
}
