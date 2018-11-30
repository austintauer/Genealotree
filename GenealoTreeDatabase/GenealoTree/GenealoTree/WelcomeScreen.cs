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
    public partial class WelcomeScreen : Form
    {
        List<Person> people;
        public WelcomeScreen(List<Person> people)
        {
            InitializeComponent();
            this.people = people;
            this.WindowState = FormWindowState.Maximized;

            foreach (Person p in people)
            {
                personListBox.Items.Add(p);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form f1 = new AddModifyForm(people, null);
            this.Hide();
            f1.Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            if (personListBox.SelectedIndex != -1)
            {
                Form f1 = new RelationshipForm(people, (Person)personListBox.SelectedItem);
                this.Hide();
                f1.Show();
            }
                
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            if (personListBox.SelectedIndex != -1)
            {
                Form f1 = new PersonalInformationForm(people, (Person)personListBox.SelectedItem);
                this.Hide();
                f1.Show();
            }
            
        }
    }
}
