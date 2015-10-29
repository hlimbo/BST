using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    class BST
    {
        //a list holding people's names and weights.
        private List<Node> records = new List<Node>();

        //the root of the bst.
        public Node root
        {
            get;
            private set;
        }

        public void add(Person p)
        {
            //trivial case
            if (root == null)
            {
                root = new Node(p);
                return;
            }
         
            Node current = root;
            while (current != null)
            {
                if (String.Compare(p.Name,current.person.Name) <= 0)
                {
                    //if node to the right is empty, the current's left node is instantiated with the new data.
                    //otherwise, current traverses left of the tree.
                    if (current.left == null)
                    {
                        current.left = new Node(p);
                        break;
                    }
                    else
                        current = current.left;
                }
                else
                {
                    if (current.right == null)
                    {
                        current.right = new Node(p);
                        break;
                    }
                    else
                        current = current.right;
                }
            }
        }

        public void preOrder(Node root)                                         
        {
            //vlr pattern

             if (root == null)
                return;

            Node left = root.left;
            Node right = root.right;
            root.print();
            preOrder(left);
            preOrder(right);
           

        }

        public void inOrder(Node root)
        {
            //lvr pattern
            if (root == null)
                return;

            Node left = root.left;
            Node right = root.right;

            inOrder(left);
            records.Add(root);
            root.print();
            inOrder(right);
        }

        public void postOrder(Node root)
        {
            //lrv pattern
            if (root == null)
                return;

            Node left = root.left;
            Node right = root.right;
            postOrder(left);
            postOrder(right);
            root.print();
        }

        //recursively counts the left height and right height of the tree.
        //returns the max height of tree.
        public int Height(Node root)
        {
            if (root == null)
                return -1;

            int leftht = Height(root.left);
            int rightht = Height(root.right);
          
            if (leftht > rightht)
                return leftht + 1;

            return rightht + 1;
        }

        public int Leaves(Node root)
        {
            //trivial case
            if (root == null)
                return 0;

            if (root.left == null && root.right == null)
                return 1;

            int leftleaves = Leaves(root.left);
            int rightleaves = Leaves(root.right);


            return leftleaves + rightleaves;
        }

        public string search(Node root,string name)
        {
            //trivial case - if tree's root is empty OR if subroot is empty, return an empty string.
             if (root == null)
                return "";

             string p = root.person.Name;
             
             if (p.Equals(name))
                 return p + "'s weight: " + root.person.Weight;

            string left = search(root.left, name);
            string right = search(root.right, name);

            return left + right;

        }

        //used the inorder method to store people's names and weights into a list of records.
        public int LowWeight()
        {
            int low = -1;
            if(root == null)
                return low;

            low = records[0].person.Weight;
            for (int i = 1; i < records.Count; i++)
            {
                if (low > records[i].person.Weight)
                    low = records[i].person.Weight;
            }

            return low;
        }


        //finds first name in list in alphabetical order
        public string findName()
        {
            //if the tree was not made
            if(root == null)
                return "";            
            
            Node current = root;
            string name = current.person.Name;

            //traverse to the leftmost tree to get the first name in alphabetical order.
            while (current != null)
            {
                name = current.person.Name;
                current = current.left;
            }

            return name;
        }


        //method that prints the information about the BST which also includes the search method inside.
        public void printState()
        {
            Console.WriteLine("Tree State");
            Console.WriteLine("Height: " + Height(root));
            Console.WriteLine("Leaves: " + Leaves(root));
            
            //Get out of method if the tree is empty.
            if (root == null)
            {
                Console.WriteLine("The tree is empty\n");
                return;
            }

            Console.WriteLine("\nPreorder");
            //list needs to be cleared to avoid duplicate records
            records.Clear();
            preOrder(root);
            Console.WriteLine();
            Console.WriteLine("In order");
            inOrder(root);
            Console.WriteLine();
            Console.WriteLine("Postorder");
            postOrder(root);
            Console.WriteLine();
            
            Console.WriteLine("\nFirst Name in alphabetical order: " + findName());
            Console.WriteLine("Lowest Weight int the tree: " + LowWeight());

            Console.Write("Enter a name to search for: ");
            string s = Console.ReadLine();
            if (search(root, s).Equals(string.Empty))
                Console.WriteLine(s + " was not found");
            else
                Console.WriteLine(search(root,s));
           
        }




    }
}
