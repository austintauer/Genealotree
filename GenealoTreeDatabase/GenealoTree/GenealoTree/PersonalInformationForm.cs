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
            
            if (profilePictureBox.Image == null)
            {
                profilePictureBox.Image = Image.FromFile(@"../../Images/banana-cat.png");
            }
            else
            {
                profilePictureBox.Image = Image.FromFile(person.profilePicturePath);
            }
            
            firstNameLabel.Text = person.firstName;
            middleNameLabel.Text = person.middleName;
            lastNameLabel.Text = person.lastName;
            sexLabel.Text = person.sex;
            birthPlaceLabel.Text = person.birthPlace;
            deathPlaceLabel.Text = person.deathPlace;
            burialPlaceLabel.Text = person.burialPlace;
            cemetaryNameLabel.Text = person.cemetery;
            birthCertificateLabel.Text = person.birthCertificateNumber;
            deathCertificateLabel.Text = person.deathCertificateNumber;
            ssnLabel.Text = person.socialSecurityNumber;
            causeOfDeathLabel.Text = person.causeOfDeath;

            
            
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
                relationshipListBox.Items.Add(r.ToString());
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
    }
}
