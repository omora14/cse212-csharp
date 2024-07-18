# Binary Trees Tutorial

## Introduction to Binary Trees

A **binary tree** is a hierarchical data structure in which each node has at most two children referred to as the left child and the right child. This structure is widely used in computer science for various applications, including expression parsing, data searching, and hierarchical data representation.

### Key Properties of Binary Trees

| Property       | Description                                        |
|----------------|----------------------------------------------------|
| **Root**       | The top node of the tree.                         |
| **Node**       | Each element in the tree, containing data and links to child nodes. |
| **Edge**       | The connection between two nodes.                 |
| **Leaf**       | A node with no children (i.e., it has no left or right child). |
| **Height**     | The length of the longest path from the root to a leaf. |
| **Depth**      | The length of the path from the root to a given node. |

### Types of Binary Trees

1. **Full Binary Tree**: Every node has either 0 or 2 children.
2. **Complete Binary Tree**: All levels are completely filled except possibly the last level, which is filled from left to right.
3. **Perfect Binary Tree**: All internal nodes have exactly two children and all leaf nodes are at the same level.
4. **Balanced Binary Tree**: The height of the left and right subtrees of every node differ by at most one.
5. **Binary Search Tree (BST)**: For each node, all values in the left subtree are smaller, and all values in the right subtree are larger.

### Binary Tree Representation

A binary tree can be represented using a class-based structure in various programming languages. Here's a simple representation in C#:

```csharp
// Node class for a binary tree
public class TreeNode
{
    public int Value { get; set; }      // Value stored in the node
    public TreeNode Left { get; set; }  // Reference to the left child
    public TreeNode Right { get; set; } // Reference to the right child

    // Constructor to initialize a node with a value and optional left and right children
    public TreeNode(int value, TreeNode left = null, TreeNode right = null)
    {
        Value = value;
        Left = left;
        Right = right;
    }
}
```

### Consider the following Binary Tree

        10
       /  \
      5    20
     / \   / \
    2   7 15  25

1. Root Node: 10
2. Left Subtree: Rooted at 5
3. Right Subtree: Rooted at 20
4. Leaf Nodes: 2, 7, 15, 25

## Example

```csharp
using System;

public class TreeNode
{
    public int Value { get; set; }
    public TreeNode Left { get; set; }
    public TreeNode Right { get; set; }

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

    public static void Main()
    {
        // Create a simple binary tree
        TreeNode root = new TreeNode(10,
            new TreeNode(5,
                new TreeNode(2),
                new TreeNode(7)),
            new TreeNode(20,
                new TreeNode(15),
                new TreeNode(25)));

        BinaryTree tree = new BinaryTree { Root = root };

        Console.WriteLine("In-order Traversal:");
        tree.InOrderTraversal(tree.Root); // Output: 2 5 7 10 15 20 25
    }
}
```