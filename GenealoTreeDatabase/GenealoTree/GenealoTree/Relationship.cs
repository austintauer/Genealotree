﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenealoTree
{
    public class Relationship
    {
        public int id { get; set; }
        public string type { get; set; }

        public Relationship()
        {

        }

        public Relationship(int id, string type)
        {
            this.id = id;
            this.type = type;
        }

        
        public override string ToString()
        {
            return type + " " + id;
        }
    }
}
