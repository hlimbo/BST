using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class Program
    {
        static void Main(string[] args)
        {

            Person a = new Person("John", 12);
            Person b = new Person("Judy", 45);
            Person c = new Person("Stan", 8);
            Person d = new Person("Sam", 50);
            Person e = new Person("Viktor", 60);
            Person f = new Person("Angela", 2);
            Person g = new Person("Adam", 25);
            Person h = new Person("Blaine", 7);
            Person i = new Person("Zachary", 1);
            Person j = new Person("Carl", 57);
            Person k = new Person("Danny", 23);
            Person l = new Person("Barry", 32);
            Person m = new Person("May", 3);
            Person n = new Person("Suzy", 64);
            Person o = new Person("Gina", 23);

            BST tree = new BST();

            tree.printState();
            tree.add(j);
            tree.add(i);
            tree.add(k);
            tree.add(l);
            tree.add(m);
            tree.add(n);
            tree.add(o);
            tree.printState();
            tree.add(a);
            tree.add(b);
            tree.add(c);
            tree.add(d);
            tree.add(e);
            tree.add(f);
            tree.add(g);
            tree.add(h);
            tree.printState();         

           


        }
    }
}


/*
 * Sample output
 * 
 * Tree State
Height: -1
Leaves: 0
The tree is empty

Tree State
Height: 4
Leaves: 3

Preorder
Carl - 57
Barry - 32
Zachary - 1
Danny - 23
May - 3
Gina - 23
Suzy - 64

In order
Barry - 32
Carl - 57
Danny - 23
Gina - 23
May - 3
Suzy - 64
Zachary - 1

Postorder
Barry - 32
Gina - 23
Suzy - 64
May - 3
Danny - 23
Zachary - 1
Carl - 57


First Name in alphabetical order: Barry
Lowest Weight int the tree: 1
Enter a name to search for: Carry
Carry was not found
Tree State
Height: 6
Leaves: 5

Preorder
Carl - 57
Barry - 32
Angela - 2
Adam - 25
Blaine - 7
Zachary - 1
Danny - 23
May - 3
Gina - 23
John - 12
Judy - 45
Suzy - 64
Stan - 8
Sam - 50
Viktor - 60

In order
Adam - 25
Angela - 2
Barry - 32
Blaine - 7
Carl - 57
Danny - 23
Gina - 23
John - 12
Judy - 45
May - 3
Sam - 50
Stan - 8
Suzy - 64
Viktor - 60
Zachary - 1

Postorder
Adam - 25
Angela - 2
Blaine - 7
Barry - 32
Judy - 45
John - 12
Gina - 23
Sam - 50
Stan - 8
Viktor - 60
Suzy - 64
May - 3
Danny - 23
Zachary - 1
Carl - 57


First Name in alphabetical order: Adam
Lowest Weight int the tree: 1
Enter a name to search for: Stan
Stan's weight: 8
Press any key to continue . . .
*/