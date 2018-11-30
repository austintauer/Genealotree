using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenealoTree
{
    public partial class AddModifyForm : Form
    {
        List<Person> people;
        Person person;
        public AddModifyForm(List<Person> people, Person person = null)
        {
            InitializeComponent();

            this.person = person;
            this.people = people;

            if (person != null)
            {
                populate();
            }
            Button profilePictureButton;

            if (profilePictureBox.Image == null)
            {
                profilePictureButton = new Button();
                this.Controls.Add(profilePictureButton);
                profilePictureButton.Location = new Point(21, (profilePictureBox.Height / 2));
                profilePictureButton.Text = "Add Profile Picture";
                profilePictureButton.Width = profilePictureBox.Width;
                profilePictureButton.BackColor = System.Drawing.Color.Snow;
                profilePictureButton.Click += new EventHandler(profilePictureButton_Click);


                profilePictureBox.Visible = false;
            }
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            /*if (ofd.OpenFile() == null)   //If no file is selected, return.
            {
                return;
            }*/
            profilePictureBox.Image = new Bitmap(ofd.FileName);
        }

        private void AddModifyForm_Load(object sender, EventArgs e)
        {
            
        }

        public void populate()
        {
            profilePictureBox.Image = Image.FromFile(person.profilePicturePath);

            Button profilePictureButton;

            if (profilePictureBox.Image == null)
            {
                profilePictureButton = new Button();
                this.Controls.Add(profilePictureButton);
                profilePictureButton.Location = new Point(21, (profilePictureBox.Height / 2));
                profilePictureButton.Text = "Add Profile Picture";
                profilePictureButton.Width = profilePictureBox.Width;
                profilePictureButton.Click += new EventHandler(profilePictureButton_Click);

                profilePictureBox.Visible = false;
            }


            string birthm = "";
            string birthd = "";
            string birthy = "";
            string deathm = "";
            string deathd = "";
            string deathy = "";
            string burialm = "";
            string buriald = "";
            string burialy = "";
            try
            {
                birthm = person.birthDate.Substring(0, 2);
                birthd = person.birthDate.Substring(2, 2);
                birthy = person.birthDate.Substring(4);

                deathm = person.deathDate.Substring(0, 2);
                deathd = person.deathDate.Substring(2, 2);
                deathy = person.deathDate.Substring(4);

                burialm = person.burialDate.Substring(0, 2);
                buriald = person.burialDate.Substring(2, 2);
                burialy = person.burialDate.Substring(4);
            }
            catch (ArgumentOutOfRangeException a)
            {

            }
            

            //populate name group
            firstNameTextBox.Text = person.firstName;
            middleNameTextBox.Text = person.middleName;
            lastNameTextBox.Text = person.lastName;
            //populate birth group
            birthMonthTextBox.Text = birthm;
            birthDayTextBox.Text = birthd;
            birthYearTextBox.Text = birthy;
            birthPlaceTextBox.Text = person.birthPlace;
            birthCertificateTextBox.Text = person.birthCertificateNumber;
            //radio button sex
            switch (person.sex)
            {
                case "male":
                    maleRadioButton.Checked = true;
                    femaleRadioButton.Checked = false;
                    naSexRadioButton.Checked = false;
                    break;
                case "female":
                    maleRadioButton.Checked = false;
                    femaleRadioButton.Checked = true;
                    naSexRadioButton.Checked = false;
                    break;
                default:
                    maleRadioButton.Checked = false;
                    femaleRadioButton.Checked = false;
                    naSexRadioButton.Checked = true;
                    break;
            }
            //populate death group
            deathMonthTextBox.Text = deathm;
            deathDayTextBox.Text = deathd;
            deathYearTextBox.Text = deathy;
            deathPlaceTextBox.Text = person.deathPlace;
            deathCertificateTextBox.Text = person.deathCertificateNumber;
            causeOfDeathTextBox.Text = person.causeOfDeath;
            //populate burial group
            burialMonthTextBox.Text = burialm;
            burialDayTextBox.Text = buriald;
            burialYearTextBox.Text = burialy;
            burialPlaceTextBox.Text = person.burialPlace;
            cemetaryTextBox.Text = person.cemetery;
            //populate questions group
            foreach (String s in person.questions)
            {
                questionTextBox.Text += s + "\n";
            }
            //populate additional information group
            ssnTextBox.Text = person.socialSecurityNumber;
            //populate military service
            foreach (String s in person.militaryService)
            {
                militaryServiceTextBox.Text += s + "\n";
            }
            //populate profession
            foreach (String s in person.profession)
            {
                professionTextBox.Text += s + "\n";
            }
            //populate notes group
            foreach (String s in person.notes)
            {
                notesTextBox.Text += s + "\n";
            }

            //relationships

            //populate relationships that can be deleted
            foreach(Relationship r in person.relationships)
            {
                foreach(Person p in people) //find person with matching id to change type of relationship and add to list
                {
                    if (p.id == r.id)
                    {
                        removeRelationshipComboBox.Items.Add(new PersonRelationship(p, r));
                        break;
                    }
                }
            }

            //populate people that can be in new relationships
            foreach(Person p in people)
            {
                addPersonRelationshipComboBox.Items.Add(p);
            }

            //populate possible types for new relationships
            addTypeRelationshipComboBox.Items.Add("Parent");
            addTypeRelationshipComboBox.Items.Add("Child");
            addTypeRelationshipComboBox.Items.Add("Sibling");
            addTypeRelationshipComboBox.Items.Add("Spouse");

        }

        private void profilePictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
            /*if (ofd.OpenFile() == null)   //If no file is selected, return.
            {
                return;
            }*/
            profilePictureBox.Image = new Bitmap(ofd.FileName);
            profilePictureBox.Visible = true;
            ((Button)sender).Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Person p = new Person();
            //name box fields
            p.firstName = firstNameTextBox.Text;
            p.middleName = middleNameTextBox.Text;
            p.lastName = lastNameTextBox.Text;

            //birth box fields
            p.birthDate = birthMonthTextBox.Text + birthDayTextBox.Text + birthYearTextBox.Text;
            p.birthPlace = birthPlaceTextBox.Text;
            p.birthCertificateNumber = birthCertificateTextBox.Text;
            //sex
            string sex = "";
            bool isChecked = maleRadioButton.Checked;
            if (isChecked)
            {
                sex = maleRadioButton.Text;
            }
            else
            {
                isChecked = femaleRadioButton.Checked;
                if (isChecked)
                {
                    sex = femaleRadioButton.Text;
                }
                else
                {
                    sex = "Unknown";
                }
            }
            p.sex = sex;
            
            //death group fields
            p.deathDate = deathMonthTextBox.Text + deathDayTextBox.Text + deathYearTextBox.Text;
            p.deathPlace = deathPlaceTextBox.Text;
            p.deathCertificateNumber = deathCertificateTextBox.Text;
            p.causeOfDeath = causeOfDeathTextBox.Text;

            //burial group fields
            p.burialDate = burialMonthTextBox.Text + burialDayTextBox.Text + burialYearTextBox.Text;
            p.burialPlace = burialPlaceTextBox.Text;
            p.cemetery = cemetaryTextBox.Text;

            //additional information fields
            p.socialSecurityNumber = ssnTextBox.Text;
            //military service
            if (militaryServiceTextBox.Text != null)
            {
                p.militaryService = militaryServiceTextBox.Text.Split(',');
            }
            else
            {
                p.militaryService = new string[] { "none" };
            }
            //profession
            if (professionTextBox.Text != null)
            {
                p.profession = professionTextBox.Text.Split(',');
            }
            else
            {
                p.profession = new string[] { "none" };
            }

            //notes
            if (notesTextBox.Text != null)
            {
                p.notes = notesTextBox.Text.Split(',');
            }
            else
            {
                p.notes = new string[] { "none" };
            }

            //questions
            if (questionTextBox.Text != null)
            {
                p.questions = questionTextBox.Text.Split(',');
            }
            else
            {
                p.questions = new string[] { "none" };
            }

            Form newPerson = new PersonalInformationForm(people, p);
            this.Close();
            newPerson.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RemoveRelationshipComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (removeRelationshipComboBox.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove " + removeRelationshipComboBox.SelectedText + "?", "Remove Relationship", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    person.relationships.Remove( ((PersonRelationship) removeRelationshipComboBox.SelectedItem).relationship);

                    ((PersonRelationship)removeRelationshipComboBox.SelectedItem).person.relationships.Remove(((PersonRelationship)removeRelationshipComboBox.SelectedItem).relationship);

                    removeRelationshipComboBox.Items.Remove(removeRelationshipComboBox.SelectedItem);
                    
                    

                    removeRelationshipComboBox.SelectedIndex = -1;

                }
                else if (dialogResult == DialogResult.No)
                {
                    removeRelationshipComboBox.SelectedIndex = -1;
                }
            }

            
        }

        private void addRelationshipButton_Click(object sender, EventArgs e)
        {
            if (addPersonRelationshipComboBox.SelectedIndex != -1 && addTypeRelationshipComboBox.SelectedIndex != -1)
            {
                Relationship newRelationship = new Relationship(((Person)addPersonRelationshipComboBox.SelectedItem).id, (string)addTypeRelationshipComboBox.SelectedItem);

                person.relationships.Add(newRelationship);

                removeRelationshipComboBox.Items.Add(new PersonRelationship((Person)addPersonRelationshipComboBox.SelectedItem, newRelationship));

                ((Person)addPersonRelationshipComboBox.SelectedItem).relationships.Add(new Relationship(person.id, (string)addTypeRelationshipComboBox.SelectedItem));

                MessageBox.Show("The relationship," + (string)addTypeRelationshipComboBox.SelectedItem + ": " + ((Person)addPersonRelationshipComboBox.SelectedItem).ToString() + ", has been successfully added.");
            }
            
        }
    }
}
