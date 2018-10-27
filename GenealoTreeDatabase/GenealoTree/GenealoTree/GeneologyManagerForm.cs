using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeneologyManager
{
    public partial class GeneologyManagerForm : Form
    {
        public GeneologyManagerForm()
        {
            InitializeComponent();
        }

        private void birthFileBrowseButton_Click(object sender, EventArgs e)
        {
            DialogResult result = birthOpenFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                string name = birthOpenFileDialog.FileName;
                birthAttachmentListBox.Items.Add(name);
            }
        }

        private void birthFileRemoveButton_Click(object sender, EventArgs e)
        {
            birthAttachmentListBox.Items.Remove(birthAttachmentListBox.SelectedItem);
        }
    }
}
