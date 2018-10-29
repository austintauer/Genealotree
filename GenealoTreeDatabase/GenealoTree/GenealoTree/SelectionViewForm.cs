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
    public partial class SelectionViewForm : Form
    {
        static Person selected = null;

<<<<<<< HEAD
        Person[] persons = new Person[4];
        Relationship[] relationships = new Relationship[4];

        public SelectionViewForm(Person p)
        {
            InitializeComponent();
=======
        public SelectionViewForm()
        {
            InitializeComponent();
        }

        private void SelectionViewForm_Load(object sender, EventArgs e)
        {
            Person[] persons = new Person[3];
            Relationship[] relationships = new Relationship[2];

>>>>>>> 44b5b7045845444ecd788e04b0d700cd9440fc72
            persons[0] = new Person('a');
            persons[1] = new Person('a');
            persons[2] = new Person('a');

            persons[1].firstName = "Emily";
            persons[2].firstName = "Taylor";

            relationships[0] = new Relationship(persons[0], persons[1], "ParentChild");
            relationships[1] = new Relationship(persons[1], persons[2], "ParentChild");
<<<<<<< HEAD
            relationships[2] = new Relationship(persons[0], persons[3], "Sibling");
            relationships[3] = new Relationship(persons[3], persons[1], "ParentChild");

            changeSelected(p);
        }

        private void SelectionViewForm_Load(object sender, EventArgs e)
        {
            

            
        }


        private void changeSelected(Person p)
        {
            selected = p;
            this.Controls.Clear();
=======
>>>>>>> 44b5b7045845444ecd788e04b0d700cd9440fc72

            List<Relationship> parentRelationShips = new List<Relationship>();
            List<Relationship> childRelationShips = new List<Relationship>();

            if (selected == null)
            {
                selected = persons[0];
            }
            /*if (selected == null)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }*/

            foreach (Relationship r in relationships)
            {
                if (r.person2 == selected)
                {
                    parentRelationShips.Add(r);
                }
                else if (r.person1 == selected)
                {
                    childRelationShips.Add(r);
                }
            }

            int index = 0;
            foreach (Relationship r in parentRelationShips)
            {
                GroupBox parentBox = r.person1.createGroupBox();
                parentBox.Location = new Point(index * 120 + 10, 10);
                index++;
                this.Controls.Add(parentBox);

            }

            GroupBox selBox = selected.createGroupBox();
            selBox.Location = new Point(10, 110);
            selBox.BackColor = Color.Yellow;
            RichTextBox selText = selBox.Controls.OfType<RichTextBox>().ToArray()[0];
            selText.BackColor = Color.Yellow;
            

            this.Controls.Add(selBox);


            index = 0;
            foreach (Relationship r in childRelationShips)
            {
                GroupBox childBox = r.person2.createGroupBox();
                childBox.Location = new Point(index * 120 + 10, 220);
                index++;
                this.Controls.Add(childBox);
            }
        }

        public void viewDetails()
        {

        }
    }
}
