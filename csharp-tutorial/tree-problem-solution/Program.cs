// program.cs

using System;

public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

    // Constructor for TreeNode class
    public TreeNode(int value, TreeNode left = null, TreeNode right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}

public class BinaryTree
{
    public TreeNode Root { get; set; }

    // Method to insert a value into the binary search tree
    public void Insert(int value)
    {
        Root = InsertRec(Root, value);
    }

    // Helper method for insertion
    private TreeNode InsertRec(TreeNode root, int value)
    {
        if (root == null)
        {
            root = new TreeNode(value);
            return root;
        }

        if (value < root.Value)
        {
            root.Left = InsertRec(root.Left, value);
        }
        else if (value > root.Value)
        {
            root.Right = InsertRec(root.Right, value);
        }

        return root;
    }

    // In-order traversal of the binary tree
    public void InOrderTraversal(TreeNode node)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left);
            Console.Write(node.Value + " ");
            InOrderTraversal(node.Right);
        }
    }

    // Main method to test the binary tree operations
    public static void Main()
    {
        BinaryTree tree = new BinaryTree();

        // Inserting values into the binary tree
        tree.Insert(10);
        tree.Insert(5);
        tree.Insert(20);
        tree.Insert(2);
        tree.Insert(7);
        tree.Insert(15);
        tree.Insert(25);

        // Displaying the binary tree's in-order traversal
        Console.WriteLine("In-order Traversal:");
        tree.InOrderTraversal(tree.Root); // Output: 2 5 7 10 15 20 25
    }
}