// binary-tree-problem.cs

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

    // TODO: Implement this method to insert a value into the binary search tree.
    // The method should maintain the binary search tree properties.
    public void Insert(int value)
    {
        // TODO: Write your code here
    }

    // TODO: Implement this method to perform an in-order traversal of the binary tree.
    // The traversal should visit nodes in ascending order of their values.
    public void InOrderTraversal(TreeNode node)
    {
        // TODO: Write your code here
    }

    // Main method to test your implementation
    public static void Main()
    {
        BinaryTree tree = new BinaryTree();

        // Insert the following values into the binary tree: 10, 5, 20, 2, 7, 15, 25
        // You should implement the Insert method to perform these insertions.

        // Display the binary tree's in-order traversal
        Console.WriteLine("In-order Traversal:");
        tree.InOrderTraversal(tree.Root); // Expected output: 2 5 7 10 15 20 25

        // Add additional tests as needed to verify your implementation
    }
}