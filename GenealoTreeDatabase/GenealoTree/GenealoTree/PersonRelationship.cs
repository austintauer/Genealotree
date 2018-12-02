using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenealoTree
{
    class PersonRelationship
    {
        public Person person { get; set; }

        public Relationship relationship { get; set; }

        public PersonRelationship()
        {

        }

        public PersonRelationship(Person person, Relationship relationship)
        {
            this.person = person;
            this.relationship = relationship;
        }


        public override string ToString()
        {
            return relationship.type + " of " + person.ToString();
        }
    }
}
