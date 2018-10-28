using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenealoTree
{
    class Relationship
    {
        public Person person1 { get; set; }
        public Person person2 { get; set; }
        public string relationshipType { get; set; }

        public Relationship()
        {

        }

        public Relationship(Person person1, Person person2, String type)
        {
            this.person1 = person1;
            this.person2 = person2;
            this.relationshipType = type;
        }
    }
}
