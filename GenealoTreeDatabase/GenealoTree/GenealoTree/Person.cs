using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenealoTree
{
    public class Person
    {
        public int id { get; set; }
        public static int maxId { get; set; }
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

        public bool dead { get; set; }
        public bool buried { get; set; }

        public List<string> militaryService;
        public List<string> profession;
        public List<string> notes;
        public List<string> questions;

        public DateTime birthDate { get; set; }
        public DateTime deathDate { get; set; }
        public DateTime burialDate { get; set; }

        public List<Relationship> relationships { get; set; }


        public void instanciate()
        {
            id = ++maxId;
            firstName = "";
            middleName = "";
            lastName = "";
            sex = "";
            birthPlace = "";
            deathPlace = "";
            burialPlace = "";
            cemetery = "";
            birthCertificateNumber = "";
            deathCertificateNumber = "";
            socialSecurityNumber = "";
            causeOfDeath = "";

            profilePicturePath = @"../../Images/banana-cat.png";
            militaryService = new List<string>();
            profession = new List<string>();
            notes = new List<string>();
            questions = new List<string>();

            relationships = new List<Relationship>();
        }

        public Person()
        {
            instanciate();
        }
        
        public Person(string fname, string mname, string lname, string s, string birth, string death, string burial, string graveyard, string bcNum, string dcNum, string ssNum, string cod, DateTime dob, DateTime dod, DateTime doburial, List<string> militaryService, List<string> profession)
        {
            instanciate();
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
            this.militaryService = militaryService;
            this.profession = profession;
            
        }

        public GroupBox createGroupBox()
        {
            GroupBox gb = new GroupBox();
            gb.Width = 200;
            gb.Height = 250;
            gb.Text = firstName + " " + lastName;
            gb.Font = new System.Drawing.Font("Arial", 16);
            gb.BackColor = Color.Snow;

            PictureBox profilePic = new PictureBox();
            try
            {
                profilePic.Image = new Bitmap(profilePicturePath);
            }
            catch (ArgumentException a)
            {

            }

            profilePic.Location = new Point(10, 30);
            profilePic.Height = 180;
            profilePic.SizeMode = PictureBoxSizeMode.StretchImage;
            profilePic.Width = 180;
            
            gb.Controls.Add(profilePic);

            Button selectButton = new Button();
            selectButton.Text = "Select";
            selectButton.Location = new System.Drawing.Point(5, 215);
            selectButton.AutoSize = true;
            selectButton.BackColor = System.Drawing.Color.Snow;
            gb.Controls.Add(selectButton);

            Button detailsButton = new Button();
            detailsButton.Text = "Details";
            detailsButton.Location = new System.Drawing.Point(100, 215);
            detailsButton.AutoSize = true;
            detailsButton.BackColor = System.Drawing.Color.Snow;
            gb.Controls.Add(detailsButton);



            return gb;
        }

        /*
         * 
         * Expand equals to all fields. 
         */
        public bool equals(Person p)
        {

            return p.firstName.Equals(this.firstName) && p.middleName.Equals(this.middleName) && p.lastName.Equals(this.lastName);
        }

        public override string ToString()
        {
            return firstName + " " + lastName;
        }
    }
}


