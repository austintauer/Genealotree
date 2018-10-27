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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Person person = new Person();

            Text = person.firstName + " " + person.lastName + "'s Personal Information";
            profilePictureBox.Image = Image.FromFile(person.profilePicturePath);

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
            militaryServiceLabel.Text = person.militaryService.ToString();
            professionLabel.Text = person.profession.ToString();
            notesLabel.Text = person.notes.ToString();
            questionsLabel.Text = person.notes.ToString();
            


            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
