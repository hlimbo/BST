using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Person
    {
        public String Name
        {
            get;
            private set;
        }

        public int Weight
        {
            get;
            private set;
        }

        public Person(string name, int weight)
        {
            Name = string.Copy(name);
            Weight = weight;
        }



    }
}
