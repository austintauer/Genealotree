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
    public partial class AddModifyForm : Form
    {
        public AddModifyForm()
        {
            InitializeComponent();
        }

        private void profilePictureBox_Click(object sender, EventArgs e)
        {

        }

        private void AddModifyForm_Load(object sender, EventArgs e)
        {
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
        }

        private void profilePictureButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.ShowDialog();
        }
    }
}
