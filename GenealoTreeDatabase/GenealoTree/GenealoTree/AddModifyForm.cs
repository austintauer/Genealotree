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
        public AddModifyForm(Person p = null)
        {
            InitializeComponent();
            if (p != null)
            {
                populate(p);
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

        public void populate(Person p)
        {
            profilePictureBox.Image = Image.FromFile(p.profilePicturePath);

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

            string birthm = p.birthDate.Substring(0, 2);
            string birthd = p.birthDate.Substring(2, 2);
            string birthy = p.birthDate.Substring(4);

            string deathm = p.deathDate.Substring(0, 2);
            string deathd = p.deathDate.Substring(2, 2);
            string deathy = p.deathDate.Substring(4);

            string burialm = p.burialDate.Substring(0, 2);
            string buriald = p.burialDate.Substring(2, 2);
            string burialy = p.burialDate.Substring(4);

            //populate name group
            firstNameTextBox.Text = p.firstName;
            middleNameTextBox.Text = p.middleName;
            lastNameTextBox.Text = p.lastName;
            //populate birth group
            birthMonthTextBox.Text = birthm;
            birthDayTextBox.Text = birthd;
            birthYearTextBox.Text = birthy;
            birthPlaceTextBox.Text = p.birthPlace;
            birthCertificateTextBox.Text = p.birthCertificateNumber;
            //radio button sex
            switch (p.sex)
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
            deathPlaceTextBox.Text = p.deathPlace;
            deathCertificateTextBox.Text = p.deathCertificateNumber;
            causeOfDeathTextBox.Text = p.causeOfDeath;
            //populate burial group
            burialMonthTextBox.Text = burialm;
            burialDayTextBox.Text = buriald;
            burialYearTextBox.Text = burialy;
            burialPlaceTextBox.Text = p.burialPlace;
            cemetaryTextBox.Text = p.cemetery;
            //populate questions group
            foreach (String s in p.questions)
            {
                questionTextBox.Text += s + "\n";
            }
            //populate additional information group
            ssnTextBox.Text = p.socialSecurityNumber;
            //populate military service
            foreach (String s in p.militaryService)
            {
                militaryServiceTextBox.Text += s + "\n";
            }
            //populate profession
            foreach (String s in p.profession)
            {
                professionTextBox.Text += s + "\n";
            }
            //populate notes group
            foreach (String s in p.notes)
            {
                notesTextBox.Text += s + "\n";
            }
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

            Form newPerson = new PersonalInformationForm(p);
            this.Close();
            newPerson.Show();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
