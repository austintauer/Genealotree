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
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
