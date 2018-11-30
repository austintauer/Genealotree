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

            if (person == null)
            {
                birthCalendar.Value = DateTime.Today;
                deathCalendar.Value = DateTime.Today;
                burialCalendar.Value = DateTime.Today;
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
            if (!ofd.FileName.Equals(""))
            {
                profilePictureBox.Image = new Bitmap(ofd.FileName);
            }
            
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
            

            //populate name group
            firstNameTextBox.Text = person.firstName;
            middleNameTextBox.Text = person.middleName;
            lastNameTextBox.Text = person.lastName;
            //populate birth group
            birthCalendar.Value = person.birthDate;
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
            deathCalendar.Value = person.deathDate;
            deathPlaceTextBox.Text = person.deathPlace;
            deathCertificateTextBox.Text = person.deathCertificateNumber;
            causeOfDeathTextBox.Text = person.causeOfDeath;
            //populate burial group
            burialCalendar.Value = person.burialDate;
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
            //validate that birth is not in the future
            if (DateTime.Compare(birthCalendar.Value, DateTime.Today) > 0)
            {
                MessageBox.Show("The birth date cannot be a future date.", "Date Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //validate that death is not in the future
            if (DateTime.Compare(deathCalendar.Value, DateTime.Today) > 0)
            {
                MessageBox.Show("The death date cannot be a future date.", "Date Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //validate birth date versus death date
            if (DateTime.Compare(birthCalendar.Value, deathCalendar.Value) > 0)
            {
                MessageBox.Show("The birth date must be earlier than or the same as the death date.", "Date Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //validate death date versus burial date
            if (DateTime.Compare(deathCalendar.Value, burialCalendar.Value) > 0)
            {
                MessageBox.Show("The death date must be earlier than or the same as the burial date.", "Date Input Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
                return;
            }
            //validate that first name is present
            if (firstNameTextBox.Text.Equals("") || firstNameTextBox.Text.Trim().Equals(""))
            {
                firstNameTextBox.Text = "";
                MessageBox.Show("The first name is a required field.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //validate that last name is present
            if (lastNameTextBox.Text.Equals("") || lastNameTextBox.Text.Trim().Equals(""))
            {
                lastNameTextBox.Text = "";
                MessageBox.Show("The last name is a required field.", "Required Field", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Person p = new Person();
            //name box fields
            p.firstName = firstNameTextBox.Text;
            p.middleName = middleNameTextBox.Text;
            p.lastName = lastNameTextBox.Text;

            //birth box fields
            p.birthDate = birthCalendar.Value;
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
            p.deathDate = deathCalendar.Value;
            p.deathPlace = deathPlaceTextBox.Text;
            p.deathCertificateNumber = deathCertificateTextBox.Text;
            p.causeOfDeath = causeOfDeathTextBox.Text;

            //burial group fields
            p.burialDate = burialCalendar.Value;
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
