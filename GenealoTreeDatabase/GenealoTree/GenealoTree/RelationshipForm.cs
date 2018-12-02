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
        Button homeButtonPerm;
        public RelationshipForm(List<Person> people, Person person)
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
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
            homeButtonPerm = new Button();
            homeButtonPerm.Font = homeButton.Font;
            homeButtonPerm.Text = homeButton.Text;
            homeButtonPerm.Location = new Point(20, this.Height - 80);
            homeButtonPerm.Size = homeButton.Size;
            homeButtonPerm.Click += homeButton_Click;
            homeButtonPerm.BackColor = Color.Snow;
            this.Controls.Clear();
            Graphics g = CreateGraphics();
            g.Clear(Color.PaleGreen);

            if (person == null)
            {
                person = people.First();
            }

            int dispAn = addAncestor(person, 0, findDepth(person, 0) - 1);
            
            int dispDesc = addDescendent(person, 0, findDepth(person, 0) - 1);

            this.Controls.Clear();

            if (dispAn / 2 > dispDesc / 2)
            {
                addAncestor(person, 0, findDepth(person, 0) - 1);
                addDescendent(person, dispAn / 2 - dispDesc / 2, findDepth(person, 0) - 1);
            }
            else
            {
                addAncestor(person, - dispAn / 2 + dispDesc / 2, findDepth(person, 0) - 1);
                addDescendent(person, 0, findDepth(person, 0) - 1);
            }
            

            




            addDescendent(person, 0 ,findDepth(person, 0) - 1);

            homeButton = homeButtonPerm;
            this.Controls.Add(homeButton);
        }


        private int addDescendent(Person person, int displacement, int generation)
        {
            int childDisp = 0;
            int childCount = 0;
            int spouseCount = 0;

            List<Relationship> relationships = person.relationships;

            GroupBox newGB;

            foreach (Relationship r in relationships)   //count number of children
            {
                if (r.type.Equals("Parent"))
                {
                    childCount++;
                }
            }

            foreach (Relationship r in relationships)   //count number of spouses
            {
                if (r.type.Equals("Spouse") || r.type.Equals("Divorced"))
                {
                    spouseCount++;

                    foreach (Person p in people)
                    {
                        if (p.id == r.id)
                        {
                            newGB = p.createGroupBox();

                            newGB.Location = new Point((displacement + spouseCount) * 250 + 50, generation * 300 + 10);
                            newGB.Controls.OfType<Button>().ToArray()[0].Click += delegate (Object sender2, EventArgs e2)
                            {

                                changeSelected(p);

                            };
                            this.Controls.Add(newGB);

                            

                            break;
                        }
                    }
                    
                }
            }
            
            
           foreach (Relationship r in relationships)
           {

                if (r.type.Equals("Parent"))
                {
                    foreach (Person p in people)
                    {
                        if (p.id == r.id)
                        {
                            childDisp += addDescendent(p, childDisp + displacement, generation + 1);
                            break;
                        }
                    }
                }
                    
           }

           newGB = person.createGroupBox();

           newGB.Location = new Point((displacement + childDisp / 2) * 250 + 50, generation * 300 + 10);
           newGB.Controls.OfType<Button>().ToArray()[0].Click += delegate (Object sender2, EventArgs e2)
           {

               changeSelected(person);

           };
            this.Controls.Add(newGB);






            spouseCount = 0;
            foreach (Relationship r in relationships)   //draw lines to spouses
            {
                if (r.type.Equals("Spouse") || r.type.Equals("Divorced"))
                {
                    spouseCount++;

                    foreach (Person p in people)
                    {
                        if (p.id == r.id)
                        {
                            

                            Graphics g = CreateGraphics();
                            Pen pen = new Pen(Color.Black, 3);

                            g.DrawLines(pen, new PointF[] { new PointF((displacement + childDisp / 2) * 250 + 140, generation * 300 + 280),    //lateral
                                new PointF((displacement + spouseCount) * 250 + 140, generation * 300 + 280) });

                            g.DrawLines(pen, new PointF[] { new PointF((displacement + childDisp / 2) * 250 + 140, generation * 300 + 240),    //vertical
                                new PointF((displacement + childDisp / 2) * 250 + 140, generation * 300 + 280) });

                            g.DrawLines(pen,  new PointF[] { new PointF((displacement + spouseCount) * 250 + 140, generation * 300 + 240),    //vertical
                                new PointF((displacement + spouseCount) * 250 + 140, generation * 300 + 280) });

                            break;
                        }
                    }

                }
            }



            int childDisp2 = 0;
            foreach (Relationship r in relationships)   //draw lines to children
            {
                if (r.type.Equals("Parent"))
                {
                    

                    foreach (Person p in people)
                    {
                        if (p.id == r.id)
                        {


                            Graphics g = CreateGraphics();
                            Pen pen = new Pen(Color.Black, 3);

                            



                            g.DrawLines(pen, new PointF[] { new PointF((displacement + childDisp / 2) * 250 + 140, generation * 300 + 280 ),    //lateral
                                new PointF((displacement + childDisp2) * 250 + 140, generation * 300 + 280) });

                            g.DrawLines(pen, new PointF[] { new PointF((displacement + childDisp / 2) * 250 + 140, generation * 300 + 240),    //vertical
                                new PointF((displacement + childDisp / 2) * 250 + 140, generation * 300 + 280) });

                            g.DrawLines(pen, new PointF[] { new PointF((displacement + childDisp2) * 250 + 140, generation * 300 + 280),    //vertical
                                new PointF((displacement + childDisp2) * 250 + 140, generation * 300 + 320) });


                            childDisp2++;

                            foreach (Relationship r2 in p.relationships)
                            {
                                if (r2.type.Equals("Spouse") || r2.type.Equals("Divorced"))
                                {
                                    childDisp2++;
                                }
                            }
                            

                            break;
                        }
                    }

                }
            }

            if (spouseCount >= childDisp)
            {
                return spouseCount + 1;
            }
            else
            {
                return childDisp;
            }
           
            
        }


        private int findDepth(Person person, int generation)
        {
            int depth = 0;
            int temp = 0;

            foreach (Relationship r in person.relationships)   
            {
                if (r.type.Equals("Child"))
                {
                    foreach (Person p in people)
                    {
                        if (r.id == p.id)
                        {
                            temp = findDepth(p, generation + 1);
                        }
                        break;
                    }
                    if (temp > depth)
                    {
                        depth = temp;
                    }
                }

            }
            return depth + 1;
        }


        //Add people going backward.
        private int addAncestor(Person person, int displacement, int generation)
        {
            int parentDisp = 0;
            int parentCount = 0;
            int spouseCount = 0;

            List<Relationship> relationships = person.relationships;

            GroupBox newGB;

            foreach (Relationship r in relationships)   //count number of parent
            {
                if (r.type.Equals("Child"))
                {
                    parentCount++;
                }
            }

            foreach (Relationship r in relationships)   //count number of spouses
            {
                if (r.type.Equals("Spouse") || r.type.Equals("Divorced"))
                {
                    spouseCount++;

                    foreach (Person p in people)
                    {
                        if (p.id == r.id)
                        {
                            newGB = p.createGroupBox();

                            newGB.Location = new Point((displacement + spouseCount) * 250 + 50, generation * 300 + 10);
                            newGB.Controls.OfType<Button>().ToArray()[0].Click += delegate (Object sender2, EventArgs e2)
                            {

                                changeSelected(p);

                            };
                            this.Controls.Add(newGB);



                            break;
                        }
                    }

                }
            }


            foreach (Relationship r in relationships)
            {

                if (r.type.Equals("Child"))
                {
                    foreach (Person p in people)
                    {
                        if (p.id == r.id)
                        {
                            parentDisp += addAncestor(p, parentDisp + displacement, generation - 1);
                            break;
                        }
                    }
                }

            }

            newGB = person.createGroupBox();

            newGB.Location = new Point((displacement + parentDisp / 2) * 250 + 50, generation * 300 + 10);
            newGB.Controls.OfType<Button>().ToArray()[0].Click += delegate (Object sender2, EventArgs e2)
            {

                changeSelected(person);

            };
            this.Controls.Add(newGB);
            






            spouseCount = 0;
            foreach (Relationship r in relationships)   //draw lines to spouses
            {
                if (r.type.Equals("Spouse") || r.type.Equals("Divorced"))
                {
                    spouseCount++;

                    foreach (Person p in people)
                    {
                        if (p.id == r.id)
                        {


                            Graphics g = CreateGraphics();
                            Pen pen = new Pen(Color.Black, 3);

                            g.DrawLines(pen, new PointF[] { new PointF((displacement + parentDisp / 2) * 250 + 140, generation * 300 + 280),    //lateral
                                new PointF((displacement + spouseCount) * 250 + 140, generation * 300 + 280) });

                            g.DrawLines(pen, new PointF[] { new PointF((displacement + parentDisp / 2) * 250 + 140, generation * 300 + 240),    //vertical
                                new PointF((displacement + parentDisp / 2) * 250 + 140, generation * 300 + 280) });

                            g.DrawLines(pen, new PointF[] { new PointF((displacement + spouseCount) * 250 + 140, generation * 300 + 240),    //vertical
                                new PointF((displacement + spouseCount) * 250 + 140, generation * 300 + 280) });

                            break;
                        }
                    }

                }
            }



            int parentDisp2 = 0;
            foreach (Relationship r in relationships)   //draw lines to parentren
            {
                if (r.type.Equals("Child"))
                {


                    foreach (Person p in people)
                    {
                        if (p.id == r.id)
                        {


                            Graphics g = CreateGraphics();
                            Pen pen = new Pen(Color.Black, 3);





                            g.DrawLines(pen, new PointF[] { new PointF((displacement + parentDisp / 2) * 250 + 140, generation * 300 + 280 ),    //lateral
                                new PointF((displacement + parentDisp2) * 250 + 140, generation * 300 + 280) });

                            g.DrawLines(pen, new PointF[] { new PointF((displacement + parentDisp / 2) * 250 + 140, generation * 300 + 240),    //vertical
                                new PointF((displacement + parentDisp / 2) * 250 + 140, generation * 300 + 280) });

                            g.DrawLines(pen, new PointF[] { new PointF((displacement + parentDisp2) * 250 + 140, generation * 300 + 280),    //vertical
                                new PointF((displacement + parentDisp2) * 250 + 140, generation * 300 + 320) });


                            parentDisp2++;

                            foreach (Relationship r2 in p.relationships)
                            {
                                if (r2.type.Equals("Spouse") || r2.type.Equals("Divorced"))
                                {
                                    parentDisp2++;
                                }
                            }

                            

                            break;
                        }
                    }

                }
            }

            if (spouseCount >= parentDisp)
            {
                return spouseCount + 1;
            }
            else
            {
                return parentDisp;
            }
        }











        public void viewDetails(Person p)
        {
            
            PersonalInformationForm details = new PersonalInformationForm(people, p);
            this.Hide();
            details.ShowDialog();
            
            //this.Close();
        }

        private void homeButton_Click(object sender, EventArgs e)
        {
            WelcomeScreen home = new WelcomeScreen(people);
            this.Hide();
            home.ShowDialog();
        }
    }
}
