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
        string filePath = "";
        public AddModifyForm(List<Person> people, Person person = null)
        {
            InitializeComponent();

            this.person = person;
            this.people = people;

            if (person != null)
            {
                populate();

                if (!person.dead)
                {
                    deathCalendar.Visible = false;
                    deathPlaceTextBox.Visible = false;
                    deathCertificateTextBox.Visible = false;
                    causeOfDeathTextBox.Visible = false;
                    buriedCheckBox.Visible = false;
                    burialCalendar.Visible = false;
                    burialPlaceTextBox.Visible = false;
                    cemetaryTextBox.Visible = false;
                    
                }

                if (!person.buried)
                {
                    
                    burialCalendar.Visible = false;
                    burialPlaceTextBox.Visible = false;
                    cemetaryTextBox.Visible = false;
                }

            }
            else
            {
                nullPopulate();
                this.person = new Person();
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
                filePath = ofd.FileName;
            }
            
        }

        private void AddModifyForm_Load(object sender, EventArgs e)
        {
            
        }

        public void populate()
        {
            try
            {
                profilePictureBox.Image = Image.FromFile(person.profilePicturePath);
                filePath = person.profilePicturePath;
            }
            catch(ArgumentException a)
            {
                profilePictureBox.Image = Image.FromFile(@"../../Images/banana-cat.png");
            }
            

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
            if (person.birthDate != DateTime.MinValue)
            {
                birthCalendar.Value = person.birthDate;
            }
            else
            {
                birthCalendar.Value = DateTime.Today;
            }
            
            birthPlaceTextBox.Text = person.birthPlace;
            birthCertificateTextBox.Text = person.birthCertificateNumber;

            if (!person.birthKnown)
            {
                birthCalendar.Visible = false;
            }

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
            if (person.dead)
            {
                if (person.deathDate <= DateTimePicker.MinimumDateTime)
                {
                    deathCalendar.Value = DateTimePicker.MinimumDateTime;
                }
                else
                {
                    deathCalendar.Value = person.deathDate;
                }
                
                deadCheckBox.Checked = true;
            }
            else
            {
                deathCalendar.Value = DateTime.Today;
                deadCheckBox.Checked = false;
            }
            deathPlaceTextBox.Text = person.deathPlace;
            deathCertificateTextBox.Text = person.deathCertificateNumber;
            causeOfDeathTextBox.Text = person.causeOfDeath;

            if (!person.dead)
            {
                deathKnownCheckBox.Visible = false;
            }

            if (!person.deathKnown)
            {
                deathCalendar.Visible = false;
            }

            //populate burial group
            if (person.buried)
            {
                if (person.burialDate <= DateTimePicker.MinimumDateTime)
                {
                    burialCalendar.Value = DateTimePicker.MinimumDateTime;
                }
                else
                {
                    burialCalendar.Value = person.burialDate;
                }
                buriedCheckBox.Checked = true;
            }
            else
            {
                burialCalendar.Value = DateTime.Today;
                buriedCheckBox.Checked = false;
            }
            burialPlaceTextBox.Text = person.burialPlace;
            cemetaryTextBox.Text = person.cemetery;

            if (!person.buried)
            {
                burialKnownCheckBox.Visible = false;
            }

            if (!person.burialKnown)
            {
                burialCalendar.Visible = false;
            }

            //populate questions group
            foreach (String s in person.questions)
            {
                questionListBox.Items.Add(s);
            }
            //populate additional information group
            ssnTextBox.Text = person.socialSecurityNumber;
            //populate military service
            foreach (String s in person.militaryService)
            {
                militaryListBox.Items.Add(s);
            }
            //populate profession
            foreach (String s in person.profession)
            {
                professionListBox.Items.Add(s);
            }
            //populate notes group
            foreach (String s in person.notes)
            {
                noteListBox.Items.Add(s);
            }

            //relationships

            //populate relationships that can be deleted
            foreach(Relationship r in person.relationships)
            {
                foreach(Person p in people) //find person with matching id to change type of relationship and add to list
                {
                    if (p.id == r.id)
                    {
                        relationshipListBox.Items.Add(new PersonRelationship(p, r));
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
            try
            {
                profilePictureBox.Image = new Bitmap(ofd.FileName);
                profilePictureBox.Visible = true;
                ((Button)sender).Visible = false;
            }
            catch (ArgumentException a)
            {

            }
            
        }

        //populates form if new person is being created
        private void nullPopulate()
        {
            //populate people that can be in new relationships
            foreach (Person p in people)
            {
                addPersonRelationshipComboBox.Items.Add(p);
            }

            //populate possible types for new relationships
            addTypeRelationshipComboBox.Items.Add("Parent");
            addTypeRelationshipComboBox.Items.Add("Child");
            addTypeRelationshipComboBox.Items.Add("Spouse");
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
            if (DateTime.Compare(birthCalendar.Value, deathCalendar.Value) > 0  && !deadCheckBox.Checked)
            {
                MessageBox.Show("The birth date must be earlier than or the same as the death date.", "Date Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //validate death date versus burial date
            if (DateTime.Compare(deathCalendar.Value, burialCalendar.Value) > 0 && !buriedCheckBox.Checked)
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

            
            if (person == null)
            {
                person = new Person();
                people.Add(person);
            }

            person.profilePicturePath = filePath;

            //name box fields
            person.firstName = firstNameTextBox.Text;
            person.middleName = middleNameTextBox.Text;
            person.lastName = lastNameTextBox.Text;

            //birth box fields
            person.birthDate = birthCalendar.Value;
            person.birthPlace = birthPlaceTextBox.Text;
            person.birthCertificateNumber = birthCertificateTextBox.Text;
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
            person.sex = sex;

            //death group fields
            if (deadCheckBox.Checked)
            {
                person.dead = true;
                person.deathDate = deathCalendar.Value;
                person.deathPlace = deathPlaceTextBox.Text;
                person.deathCertificateNumber = deathCertificateTextBox.Text;
                person.causeOfDeath = causeOfDeathTextBox.Text;
            }
            else
            {
                person.dead = false;
                person.buried = false;
                person.deathDate = DateTime.MinValue;
                person.deathPlace = "";
                person.deathCertificateNumber = "";
                person.causeOfDeath = "";
                person.burialDate = DateTime.MinValue;
                person.burialPlace = "";
                person.cemetery = "";
            }
            

            //burial group fields
            if (buriedCheckBox.Checked)
            {
                person.buried = true;
                person.burialDate = burialCalendar.Value;
                person.burialPlace = burialPlaceTextBox.Text;
                person.cemetery = cemetaryTextBox.Text;
            }
            else
            {
                person.buried = false;
                person.burialDate = DateTime.MinValue;
                person.burialPlace = "";
                person.cemetery = "";
            }
            

            //additional information fields
            person.socialSecurityNumber = ssnTextBox.Text;

            //military service

            person.militaryService = militaryListBox.Items.Cast<string>().ToList();
            
            //profession

            person.profession = professionListBox.Items.Cast<string>().ToList();

            //notes
            person.notes = noteListBox.Items.Cast<string>().ToList();

            //questions
            person.questions = questionListBox.Items.Cast<string>().ToList();

            foreach (string s in Directory.GetFiles(@"../../PersonFiles/")) {
                File.Delete(s);
            }

            if (!people.Contains(person))
            {
                people.Add(person);
            }

            //save to file
            foreach (Person p in people)
            {
                FileStream fs = File.Create(@"../../PersonFiles/" + p.firstName + p.lastName + ".gt");
                StreamWriter sw = new StreamWriter(fs);
                sw.Write(p.id + "\n");
                sw.Write(p.firstName + "\n");
                sw.Write(p.middleName + "\n");
                sw.Write(p.lastName + "\n");
                sw.Write(p.sex + "\n");

                try
                {
                    File.Copy(p.profilePicturePath, @"../../Images/" + p.firstName + p.lastName + ".png", true);
                    sw.Write(@"../../Images/" + p.firstName + p.lastName + "ProfilePicture" + "\n");
                }
                catch (Exception ex) //empty file yada yada yada
                {
                    sw.Write(p.profilePicturePath + "\n");
                }
                

                
                
                sw.Write(p.birthPlace + "\n");
                sw.Write(p.deathPlace + "\n");
                sw.Write(p.burialPlace + "\n");
                sw.Write(p.cemetery + "\n");
                sw.Write(p.socialSecurityNumber + "\n");
                sw.Write(p.causeOfDeath + "\n");
                sw.Write(p.birthCertificateNumber + "\n");
                sw.Write(p.deathCertificateNumber + "\n");
                sw.Write(p.birthKnown + "\n");
                sw.Write(p.deathKnown + "\n");
                sw.Write(p.burialKnown + "\n");
                sw.Write(p.birthDate + "\n");
                sw.Write(p.deathDate + "\n");
                sw.Write(p.burialDate + "\n");
                sw.Write(p.dead + "\n");
                sw.Write(p.buried + "\n");

                foreach (string s in p.militaryService)
                {
                    sw.Write(s);
                }
                sw.Write("\n");

                foreach (string s in p.profession)
                {
                    sw.Write(s);
                }
                sw.Write("\n");

                foreach (string s in p.notes)
                {
                    sw.Write(s);
                }
                sw.Write("\n");

                foreach (string s in p.questions)
                {
                    sw.Write(s);
                }
                sw.Write("\n");

                foreach (Relationship r in p.relationships)
                {
                    sw.Write(r.type + "," + r.id + ",");
                }
                sw.Write("\n");

                sw.Close();
                fs.Close();
            }

            

            Form newPerson = new PersonalInformationForm(people, person);
            this.Hide();
            newPerson.ShowDialog();
            //this.Close();

            
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Form info = new PersonalInformationForm(people, person);
            this.Hide();
            info.ShowDialog();
            //this.Close();
        }

        private void relationshipListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void addRelationshipButton_Click(object sender, EventArgs e)
        {
            if (addPersonRelationshipComboBox.SelectedIndex != -1 && addTypeRelationshipComboBox.SelectedIndex != -1)
            {
                

                Relationship newRelationship = new Relationship(((Person)addPersonRelationshipComboBox.SelectedItem).id, (string)addTypeRelationshipComboBox.SelectedItem);

                person.relationships.Add(newRelationship);

                relationshipListBox.Items.Add(new PersonRelationship((Person)addPersonRelationshipComboBox.SelectedItem, newRelationship));

                //certain relationships type need to be inverted for the other
                if (((string)addTypeRelationshipComboBox.SelectedItem).Equals("Child")) //invert child
                {
                    ((Person)addPersonRelationshipComboBox.SelectedItem).relationships.Add(new Relationship(person.id, "Parent"));
                }
                else if (((string)addTypeRelationshipComboBox.SelectedItem).Equals("Parent"))   //invert parent
                {
                    ((Person)addPersonRelationshipComboBox.SelectedItem).relationships.Add(new Relationship(person.id, "Child"));
                }
                else    //relationship type that don't need inverting
                {
                    ((Person)addPersonRelationshipComboBox.SelectedItem).relationships.Add(new Relationship(person.id, (string)addTypeRelationshipComboBox.SelectedItem));
                }
                

                //MessageBox.Show("The relationship," + (string)addTypeRelationshipComboBox.SelectedItem + ": " + ((Person)addPersonRelationshipComboBox.SelectedItem).ToString() + ", has been successfully added.");
                addLabel.Text = "The relationship has been added.";
                addLabel.Font = new Font(addLabel.Font, FontStyle.Bold);
            }
            
        }

        private void addMilitaryButton_Click(object sender, EventArgs e)
        {
            militaryListBox.Items.Add(newMilitaryTextBox.Text);
            newMilitaryTextBox.Text = "";
        }

        private void removeMilitaryButton_Click(object sender, EventArgs e)
        {
            if (militaryListBox.SelectedIndex != -1)
            {
                militaryListBox.Items.Remove(militaryListBox.SelectedItem);
            }
        }

        private void removeProfessionButton_Click(object sender, EventArgs e)
        {
            if (professionListBox.SelectedIndex != -1)
            {
                professionListBox.Items.Remove(professionListBox.SelectedItem);
            }
        }

        private void addProfessionButton_Click(object sender, EventArgs e)
        {
            professionListBox.Items.Add(professionTextBox.Text);
            professionTextBox.Text = "";
        }

        private void removeRelationshipButton_Click(object sender, EventArgs e)
        {
            if (relationshipListBox.SelectedIndex != -1)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to remove " + relationshipListBox.SelectedItem.ToString() + "?", "Remove Relationship", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    person.relationships.Remove(((PersonRelationship)relationshipListBox.SelectedItem).relationship);

                    ((PersonRelationship)relationshipListBox.SelectedItem).person.relationships.Remove(((PersonRelationship)relationshipListBox.SelectedItem).relationship);

                    relationshipListBox.Items.Remove(relationshipListBox.SelectedItem);

                    relationshipListBox.Text = "";
                    
                    relationshipListBox.SelectedIndex = -1;

                    

                }
                else if (dialogResult == DialogResult.No)
                {
                    relationshipListBox.SelectedIndex = -1;
                }
            }
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (relationshipListBox.SelectedIndex != -1)
            {
                PersonalInformationForm view = new PersonalInformationForm(people, ((PersonRelationship)relationshipListBox.SelectedItem).person);
                view.ShowDialog();
                this.Close();
            }
        }

        private void removeQuestionButton_Click(object sender, EventArgs e)
        {
            questionListBox.Items.Remove(questionListBox.SelectedItem);
        }

        private void addQuestonButton_Click(object sender, EventArgs e)
        {
            questionListBox.Items.Add(questionTextBox.Text);
            questionTextBox.Text = "";
        }

        private void removeNoteButton_Click(object sender, EventArgs e)
        {
            noteListBox.Items.Remove(noteListBox.SelectedItem);
        }

        private void addNoteButton_Click(object sender, EventArgs e)
        {
            noteListBox.Items.Add(noteTextBox.Text);
            noteTextBox.Text = "";
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            WelcomeScreen home = new WelcomeScreen(people);
            this.Hide();
            home.ShowDialog();
        }

        private void deadCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!deadCheckBox.Checked)
            {
                deathCalendar.Visible = false;
                deathPlaceTextBox.Visible = false;
                deathCertificateTextBox.Visible = false;
                causeOfDeathTextBox.Visible = false;
                buriedCheckBox.Visible = false;
                buriedCheckBox.Checked = false;
                burialCalendar.Visible = false;
                burialPlaceTextBox.Visible = false;
                cemetaryTextBox.Visible = false;
                deathKnownCheckBox.Visible = false;
                deathKnownCheckBox.Checked = false;
                burialKnownCheckBox.Visible = false;
                burialKnownCheckBox.Checked = false;

            }
            else
            {
                deathPlaceTextBox.Visible = true;
                deathCertificateTextBox.Visible = true;
                causeOfDeathTextBox.Visible = true;
                buriedCheckBox.Visible = true;
                deathKnownCheckBox.Visible = true;
            
            }
            
        }

        private void buriedCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (!buriedCheckBox.Checked)
            {
                burialCalendar.Visible = false;
                burialPlaceTextBox.Visible = false;
                cemetaryTextBox.Visible = false;
                burialKnownCheckBox.Visible = false;
                burialKnownCheckBox.Checked = false;
            }
            else
            {
                burialPlaceTextBox.Visible = true;
                cemetaryTextBox.Visible = true;
                burialKnownCheckBox.Visible = true;
            }
        }

        private void birthKnownCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (birthKnownCheckBox.Checked)
            {
                birthCalendar.Visible = true;

            }
            else
            {
                birthCalendar.Visible = false;
            }
        }

        private void deathKnownCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (deathKnownCheckBox.Checked)
            {
                deathCalendar.Visible = true;

            }
            else
            {
                deathCalendar.Visible = false;
            }
        }

        private void burialKnownCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (burialKnownCheckBox.Checked)
            {
                burialCalendar.Visible = true;

            }
            else
            {
                burialCalendar.Visible = false;
            }
        }
    }
}
