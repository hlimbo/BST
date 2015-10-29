using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Node
    {
        public Person person
        {
            get;
            private set;
        }

        public Node left
        {
            get;
            set;
        }

        public Node right
        {
            get;
            set;
        }

        public Node()
        {
            person = null;
            left = right = null;
        }

        public Node(Person p)
        {
            person = p;
            left = right = null;
        }

        public Boolean isEmpty()
        {
            return this == null;
        }

        public void print()
        {
            Console.WriteLine(person.Name + " - " + person.Weight + "  ");
        }
    }
}
