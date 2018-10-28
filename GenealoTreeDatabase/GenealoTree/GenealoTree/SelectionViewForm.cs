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
            Person[] persons = new Person[3];
            Relationship[] relationships = new Relationship[2];

            persons[0] = new Person('a');
            persons[1] = new Person();
            persons[2] = new Person();

            persons[1].firstName = "Emily";
            persons[2].firstName = "Taylor";

            relationships[0] = new Relationship(persons[0], persons[1], "ParentChild");
            relationships[1] = new Relationship(persons[1], persons[2], "ParentChild");

            List<Relationship> parentRelationShips = new List<Relationship>();
            List<Relationship> childRelationShips = new List<Relationship>();

            if (selected == null)
            {
                selected = persons[1];
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
                GroupBox parentBox = new GroupBox();
                parentBox.Width = 100;
                parentBox.Height = 100;
                parentBox.Location = new Point(index * 120 + 10, 10);
                index++;
                parentBox.Text = r.person1.firstName;
                this.Controls.Add(parentBox);

            }

            GroupBox selfBox = new GroupBox();
            selfBox.Width = 100;
            selfBox.Height = 100;
            selfBox.Location = new Point(10, 110);
            index++;
            selfBox.Text = selected.firstName;
            this.Controls.Add(selfBox);


            index = 0;
            foreach (Relationship r in childRelationShips)
            {
                GroupBox childBox = new GroupBox();
                childBox.Width = 100;
                childBox.Height = 100;
                childBox.Location = new Point(index * 120 + 10, 210);
                index++;
                childBox.Text = r.person2.firstName;
                this.Controls.Add(childBox);

            }
        }
    }
}
