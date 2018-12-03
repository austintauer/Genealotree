using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenealoTree
{
    public partial class PersonalInformationForm : Form
    {
        Person person;
        List<Person> people;
        public PersonalInformationForm(List<Person> people, Person familyMember)
        {
            InitializeComponent();
            person = familyMember;
            this.people = people;

            Text = person.firstName + " " + person.lastName + "'s Personal Information";

            

            if (person.profilePicturePath == "")
            {
                profilePictureBox.Image = Image.FromFile(@"../../Images/banana-cat.png");

            }
            else
            {
                profilePictureBox.Image = Image.FromFile(@person.profilePicturePath);
            }
            
            firstNameLabel.Text = person.firstName;
            middleNameLabel.Text = person.middleName;
            lastNameLabel.Text = person.lastName;
            sexLabel.Text = person.sex;


            if (person.birthKnown)
            {
                birthDateLabel.Text = person.birthDate.ToShortDateString();
            }
            else
            {
                birthDateLabel.Text = "";
            }
            birthPlaceLabel.Text = person.birthPlace;

            if (person.dead)
            {
                deathPlaceLabel.Text = person.deathPlace;
                deathCertificateLabel.Text = person.deathCertificateNumber;
                causeOfDeathLabel.Text = person.causeOfDeath;

                if (person.deathKnown)
                {
                    deathDateLabel.Text = person.deathDate.ToShortDateString();
                }
                else
                {
                    deathDateLabel.Text = "";

                }
            }
            else
            {
                deathPlaceLabel.Text = "";
                deathCertificateLabel.Text = "";
                causeOfDeathLabel.Text = "";
                deathDateLabel.Text = "";
            }
            


            if (person.buried)
            {
                if (person.burialKnown)
                {
                    burialDateLabel.Text = person.burialDate.ToShortDateString();
                }
                else
                {
                    burialDateLabel.Text = "";
                }
                burialPlaceLabel.Text = person.burialPlace;
                cemetaryNameLabel.Text = person.cemetery;
            }
            else
            {
                burialPlaceLabel.Text = "";
                cemetaryNameLabel.Text = "";
                burialDateLabel.Text = "";
            }

            


            
            birthCertificateLabel.Text = person.birthCertificateNumber;
            
            ssnLabel.Text = person.socialSecurityNumber;
            

            
            
             foreach (String s in person.militaryService)
             {
                militaryListBox.Items.Add(s);
             }

            
            
            foreach (String s in person.profession)
            {
                professionListBox.Items.Add(s);
            }
            

            
            
            foreach (String s in person.notes)
            {
                noteListBox.Items.Add(s);
            }
            

            
            
            
            foreach (String s in person.questions)
            {
                questionListBox.Items.Add(s);
            }
            
            foreach (Relationship r in person.relationships)
            {
                foreach (Person p in people)
                {
                    if (p.id == r.id)
                    {
                        relationshipListBox.Items.Add(new PersonRelationship(p, r));
                    }
                }
            }
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RelationshipForm tree = new RelationshipForm(people, person);
            tree.ShowDialog();
            this.Close();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddModifyForm edit = new AddModifyForm(people, person);
            edit.ShowDialog();
            this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            WelcomeScreen home = new WelcomeScreen(people);
            this.Hide();
            home.ShowDialog();
        }
    }
}
