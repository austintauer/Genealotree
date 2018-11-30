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
    public partial class RelationshipForm : Form
    {
        Person person = null;
        List<Person> people = null;
        public RelationshipForm(List<Person> people, Person person)
        {
            InitializeComponent();
            /*persons[0] = new Person('a');
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
            relationships[3] = new Relationship(persons[3], persons[1], "ParentChild");*/

            this.person = person;
            this.people = people;
            changeSelected(person);
        }

        private void SelectionViewForm_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            

            changeSelected(person);
        }


        private void changeSelected(Person person)
        {
            this.Controls.Clear();


            List<Relationship> relationships = person.relationships;

            List<Relationship> parentRelationShips = new List<Relationship>();
            List<Relationship> childRelationShips = new List<Relationship>();
            List<Relationship> siblingRelationShips = new List<Relationship>();

            if (person == null)
            {
                person = people.First();
            }
            /*if (person == null)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
            }*/

            foreach (Relationship r in relationships)
            {
                if (r.id == person.id && r.type.Equals("Parent"))
                {
                    parentRelationShips.Add(r);
                }
                else if (r.id == person.id && r.type.Equals("Child"))
                {
                    childRelationShips.Add(r);
                }
                else if (r.id == person.id && r.type.Equals("Sibling"))
                {
                    siblingRelationShips.Add(r);
                }
            }

            Label parentLabel = new Label();
            parentLabel.Text = "Parents: ";
            parentLabel.Font = new Font(parentLabel.Font.Name, 20);
            parentLabel.AutoSize = true;
            parentLabel.Location = new Point(10, 10);
            this.Controls.Add(parentLabel);

            int index = 0;

            
            foreach (Relationship r in parentRelationShips)
            {
                Person relationshipPerson = new Person();
                foreach (Person p in people)
                {
                    if (p.id == r.id)
                    {
                        relationshipPerson = p;
                    }
                }

                GroupBox parentBox = relationshipPerson.createGroupBox();
                parentBox.Controls.OfType<Button>().ToArray()[0].Click += delegate (Object sender2, EventArgs e2)
                {
                    changeSelected(relationshipPerson);
                };


                parentBox.Location = new Point(index * 120 + 200, 10);
                index++;
                this.Controls.Add(parentBox);

            }

            Label siblingLabel = new Label();
            siblingLabel.Text = "Self/Siblings: ";
            siblingLabel.Font = new Font(siblingLabel.Font.Name, 20);
            siblingLabel.AutoSize = true;
            siblingLabel.Location = new Point(10, 150);
            this.Controls.Add(siblingLabel);

            GroupBox selBox = person.createGroupBox();
            selBox.Controls.OfType<Button>().ToArray()[0].Click += delegate (Object sender2, EventArgs e2)
            {
                viewDetails(person);
            };
            selBox.Controls.OfType<Button>().ToArray()[0].Text = "View Details";
            selBox.Location = new Point(200, 150);
            selBox.BackColor = Color.Yellow;
            RichTextBox selText = selBox.Controls.OfType<RichTextBox>().ToArray()[0];
            selText.BackColor = Color.Yellow;

            this.Controls.Add(selBox);


            index = 0;
            foreach (Relationship r in siblingRelationShips)
            {
                Person relationshipPerson = new Person();
                foreach (Person p in people)
                {
                    if (p.id == r.id)
                    {
                        relationshipPerson = p;
                    }
                }

                GroupBox siblingBox;
                if (relationshipPerson == person)
                {
                    siblingBox = relationshipPerson.createGroupBox();

                    siblingBox.Controls.OfType<Button>().ToArray()[0].Click += delegate (Object sender2, EventArgs e2)
                    {
                        changeSelected(relationshipPerson);
                    };
                }
                else
                {
                    siblingBox = relationshipPerson.createGroupBox();

                    siblingBox.Controls.OfType<Button>().ToArray()[0].Click += delegate (Object sender2, EventArgs e2)
                    {
                        changeSelected(relationshipPerson);
                    };
                }

                
                

                siblingBox.Location = new Point(index * 120 + 320, 150);
                index++;
                this.Controls.Add(siblingBox);
            }

            Label childLabel = new Label();
            childLabel.Text = "Children: ";
            childLabel.Font = new Font(childLabel.Font.Name, 20);
            childLabel.AutoSize = true;
            childLabel.Location = new Point(10, 280);
            this.Controls.Add(childLabel);

            index = 0;
            foreach (Relationship r in childRelationShips)
            {
                Person relationshipPerson = new Person();
                foreach (Person p in people)
                {
                    if (p.id == r.id)
                    {
                        relationshipPerson = p;
                    }
                }

                GroupBox childBox = relationshipPerson.createGroupBox();
                childBox.Controls.OfType<Button>().ToArray()[0].Click += delegate (Object sender2, EventArgs e2)
                {
                    changeSelected(relationshipPerson);
                };
                childBox.Location = new Point(index * 120 + 200, 280);
                index++;
                this.Controls.Add(childBox);
            }
        }

        public void viewDetails(Person p)
        {
            //this.Hide();
            PersonalInformationForm details = new PersonalInformationForm(people, p);
            details.ShowDialog();
            this.Close();
        }
    }
}
