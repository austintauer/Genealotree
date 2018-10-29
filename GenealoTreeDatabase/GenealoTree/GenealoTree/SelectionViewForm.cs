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

        public SelectionViewForm()
        {
            InitializeComponent();
        }

        private void SelectionViewForm_Load(object sender, EventArgs e)
        {
            Person[] persons = new Person[4];
            Relationship[] relationships = new Relationship[4];

            persons[0] = new Person('a');
            persons[1] = new Person('a');
            persons[2] = new Person('a');
            persons[3] = new Person('a');

            persons[1].firstName = "Emily";
            persons[2].firstName = "Taylor";
            persons[3].firstName = "Kevin";
            persons[0].sex = persons[3].sex = "Male";
            persons[1].sex = persons[2].sex = "Female";

            relationships[0] = new Relationship(persons[0], persons[1], "ParentChild");
            relationships[1] = new Relationship(persons[1], persons[2], "ParentChild");
            relationships[2] = new Relationship(persons[0], persons[3], "Sibling");
            relationships[3] = new Relationship(persons[3], persons[1], "ParentChild");

            List<Relationship> parentRelationShips = new List<Relationship>();
            List<Relationship> childRelationShips = new List<Relationship>();
            List<Relationship> siblingRelationShips = new List<Relationship>();

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
                if (r.person2 == selected && r.relationshipType.Equals("ParentChild"))
                {
                    parentRelationShips.Add(r);
                }
                else if (r.person1 == selected && r.relationshipType.Equals("ParentChild"))
                {
                    childRelationShips.Add(r);
                }
                else if ((r.person1 == selected || r.person2 == selected) && r.relationshipType.Equals("Sibling"))
                {
                    siblingRelationShips.Add(r);
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
            foreach (Relationship r in siblingRelationShips)
            {
                GroupBox siblingBox;
                if (r.person1 == selected)
                {
                    siblingBox = r.person2.createGroupBox();
                }
                else
                {
                    siblingBox = r.person1.createGroupBox();
                }
                
                
                siblingBox.Location = new Point(index * 120 + 130, 110);
                index++;
                this.Controls.Add(siblingBox);
            }


            index = 0;
            foreach (Relationship r in childRelationShips)
            {
                GroupBox childBox = r.person2.createGroupBox();
                childBox.Location = new Point(index * 120 + 10, 220);
                index++;
                this.Controls.Add(childBox);
            }
        }
    }
}
