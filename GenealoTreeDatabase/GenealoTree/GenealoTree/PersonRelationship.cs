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
        public string type { get; set; }

        public PersonRelationship()
        {

        }

        public PersonRelationship(Person person, string type)
        {
            this.person = person;
            this.type = type;
        }


        public override string ToString()
        {
            return type + ": " + person.ToString();
        }
    }
}
