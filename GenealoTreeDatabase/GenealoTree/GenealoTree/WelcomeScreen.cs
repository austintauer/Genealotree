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
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Form f1 = new AddModifyForm(null);
            f1.Show();
        }

        private void viewButton_Click(object sender, EventArgs e)
        {
            Form f1 = new RelationshipForm(null, null);
            f1.Show();
        }
    }
}
