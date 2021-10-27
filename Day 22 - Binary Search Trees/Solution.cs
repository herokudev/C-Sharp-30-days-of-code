using System;
class Node
{
    public Node left, right;
    public int data;
    public Node(int data)
    {
        this.data = data;
        left = right = null;
    }
}
class Solution
{

    public static void TraverseInOrder(Node parent, int legHeigth)
    {
        if (parent != null)
        {
            legHeigth++;
            TraverseInOrder(parent.left, legHeigth);
            //Console.WriteLine(parent.data + " ");
            TraverseInOrder(parent.right, legHeigth);
            routesList.Add(legHeigth);
        }
        else legHeigth = 0;
    }

    public static System.Collections.Generic.List<int> routesList = new System.Collections.Generic.List<int>();
    static int getHeight(Node root)
    {
        int maxHeight = 0;

        //Write your code here
        if (root == null)
        {
            return 0;
        }
        else
        {
            int legHeigth = 0;
            TraverseInOrder(root, legHeigth);
            foreach (int x in routesList)
            {
                legHeigth = x;
                if (legHeigth > maxHeight) maxHeight = legHeigth;
            }
            maxHeight--; //num nodes minus root node
            return maxHeight;
        }
    }


    static Node insert(Node root, int data)
    {
        if (root == null)
        {
            return new Node(data);
        }
        else
        {
            Node cur;
            if (data <= root.data)
            {
                cur = insert(root.left, data);
                root.left = cur;
            }
            else
            {
                cur = insert(root.right, data);
                root.right = cur;
            }
            return root;
        }
    }
    static void Main(String[] args)
    {
        Node root = null;
        int T = Int32.Parse(Console.ReadLine());
        while (T-- > 0)
        {
            int data = Int32.Parse(Console.ReadLine());
            root = insert(root, data);
        }
        int height = getHeight(root);
        Console.WriteLine(height);

    }
}