# Binary Tree Data Structure Tutorial

## Navigation

1. [Start Solving](binary-tree-problem.cs)
2. [Go Back](../../README.md)
3. [Outline](../outline.md)

## Introduction

A **Binary Tree** is a structure used to organize data. Each element in this structure is called a **node**, and each node can connect to up to two other nodes, known as its **children**. The very top node is called the **root**. Binary trees are used in many computer science applications, like organizing data in a way that makes it easy to search through.

### Real-World Example: Organizational Hierarchy

Imagine the structure of a company. The CEO is at the top (the root), and each department head reports to the CEO. Each department head might have managers who report to them, and each manager might have employees who report to them. This can be represented as a binary tree, where each person can have up to two direct reports.

## When to Use a Binary Tree

Binary trees are useful in many situations. Here are some examples:

1. **Hierarchical Data Representation**: They are great for representing data with a hierarchy, like organizational charts, file systems, and decision trees.
2. **Efficient Searching and Sorting**: Binary Search Trees (BSTs) make searching, inserting, and deleting data efficient. They are often used in databases and file systems for quick data retrieval.
3. **Expression Parsing**: Binary trees help in parsing and evaluating expressions, such as arithmetic expressions in compilers.
4. **Priority Queues**: Binary heaps, a type of binary tree, are used to manage priority queues.
5. **Balanced Search Trees**: Types like AVL trees or Red-Black trees keep the tree balanced for efficient operations.

### Example Scenario

Imagine building a search engine. You need to index and quickly retrieve documents based on keywords. A binary search tree can help organize the keywords for efficient search and retrieval, making it easy to access relevant documents quickly.

## Components of a Binary Tree

| Component   | Description                                           |
|-------------|-------------------------------------------------------|
| **Node**    | An element in the tree. Contains a value and references to left and right children. |
| **Root**    | The top node of the tree.                           |
| **Left Child** | A direct descendant on the left. |
| **Right Child** | A direct descendant on the right.|
| **Leaf**    | A node with no children.                             |
| **Subtree** | A tree consisting of a node and all its descendants.  |

## Types of Binary Trees

1. **Full Binary Tree**: Every node has either 0 or 2 children.
2. **Complete Binary Tree**: All levels are fully filled except possibly the last level, which is filled from left to right.
3. **Perfect Binary Tree**: All internal nodes have two children, and all leaf nodes are at the same level.
4. **Binary Search Tree (BST)**: A binary tree where each node’s left children contain values less than the node’s value, and each right child contains values greater than the node’s value.
5. **Balanced Binary Tree**: A binary tree where the height of the left and right subtrees of any node differ by at most one.

## Basic Operations

1. **Insertion**: Adding a new node to the tree while maintaining the tree's properties.
2. **Deletion**: Removing a node from the tree, which may require adjusting the tree to maintain its properties.
3. **Traversal**: Visiting all nodes in a specific order. Common methods include:
   - **In-Order Traversal**: Left subtree, root, right subtree.
   - **Pre-Order Traversal**: Root, left subtree, right subtree.
   - **Post-Order Traversal**: Left subtree, right subtree, root.
   - **Level-Order Traversal**: Visiting nodes level by level from top to bottom.

## Advantages of Binary Trees

- **Hierarchical Data Representation**: Great for representing data with a hierarchy.
- **Efficient Searching**: Especially in binary search trees, search operations can be very efficient.
- **Dynamic Size**: Can grow and shrink without needing contiguous memory.

## Disadvantages of Binary Trees

- **Memory Usage**: Each node requires extra memory for storing child references.
- **Complexity**: Managing and maintaining balanced binary trees can be complex.

## Example Implementation in C# with Real-World Scenario: Company Organizational Structure

Here's a detailed C# implementation of a binary tree representing a company organizational structure with comments explaining each part of the code:

```csharp
using System;

// Represents an employee in the organization
public class Employee
{
    public string Name { get; set; }
    public Employee Left { get; set; }  // Left child represents a direct report
    public Employee Right { get; set; } // Right child represents a direct report

    public Employee(string name)
    {
        Name = name;
        Left = null;
        Right = null;
    }
}

// Represents the entire company structure
public class Organization
{
    private Employee root; // The CEO of the company

    // Constructor to initialize an empty organization
    public Organization()
    {
        root = null;
    }

    // Add a new employee to the organization
    public void AddEmployee(string boss, string employee, bool isLeft)
    {
        if (root == null)
        {
            // If there is no CEO, the first employee is the CEO
            root = new Employee(employee);
        }
        else
        {
            // Find the boss and add the new employee as their direct report
            Employee bossNode = FindEmployee(root, boss);
            if (bossNode != null)
            {
                if (isLeft)
                    bossNode.Left = new Employee(employee);
                else
                    bossNode.Right = new Employee(employee);
            }
        }
    }

    // Find an employee in the organization
    private Employee FindEmployee(Employee node, string name)
    {
        if (node == null || node.Name == name)
            return node;

        Employee foundNode = FindEmployee(node.Left, name);
        if (foundNode == null)
            foundNode = FindEmployee(node.Right, name);

        return foundNode;
    }

    // Display the organizational structure using in-order traversal
    public void DisplayInOrder()
    {
        InOrderTraversal(root);
        Console.WriteLine();
    }

    private void InOrderTraversal(Employee node)
    {
        if (node != null)
        {
            InOrderTraversal(node.Left);
            Console.Write(node.Name + " ");
            InOrderTraversal(node.Right);
        }
    }

    // Display the organizational structure using pre-order traversal
    public void DisplayPreOrder()
    {
        PreOrderTraversal(root);
        Console.WriteLine();
    }

    private void PreOrderTraversal(Employee node)
    {
        if (node != null)
        {
            Console.Write(node.Name + " ");
            PreOrderTraversal(node.Left);
            PreOrderTraversal(node.Right);
        }
    }

    // Display the organizational structure using post-order traversal
    public void DisplayPostOrder()
    {
        PostOrderTraversal(root);
        Console.WriteLine();
    }

    private void PostOrderTraversal(Employee node)
    {
        if (node != null)
        {
            PostOrderTraversal(node.Left);
            PostOrderTraversal(node.Right);
            Console.Write(node.Name + " ");
        }
    }
}

public class Program
{
    public static void Main()
    {
        Organization org = new Organization();

        // Adding employees to the organization
        org.AddEmployee("", "CEO", true);       // Adding the CEO
        org.AddEmployee("CEO", "CTO", true);    // CTO reports to CEO
        org.AddEmployee("CEO", "CFO", false);   // CFO reports to CEO
        org.AddEmployee("CTO", "Dev1", true);   // Dev1 reports to CTO
        org.AddEmployee("CTO", "Dev2", false);  // Dev2 reports to CTO
        org.AddEmployee("CFO", "Fin1", true);   // Fin1 reports to CFO
        org.AddEmployee("CFO", "Fin2", false);  // Fin2 reports to CFO

        // Display the organizational structure using different traversals
        Console.WriteLine("In-Order Traversal:");
        org.DisplayInOrder();

        Console.WriteLine("Pre-Order Traversal:");
        org.DisplayPreOrder();

        Console.WriteLine("Post-Order Traversal:");
        org.DisplayPostOrder();
    }
}
```

## Real-World Problem: File System Organization

Consider a file system where files and directories are organized in a hierarchical structure. A binary tree can represent this hierarchy, where each node represents a directory (which may have up to two subdirectories) or a file. For example:

1. Root Directory: The main directory at the top.
2. Subdirectories: Each directory can have up to two subdirectories (left and right children).
3. Files: Each file is represented as a leaf node with no children.

# Conclusion

Binary trees are a versatile data structure that supports efficient searching, insertion, and deletion operations, especially in binary search trees. They are used to represent hierarchical data, such as organizational charts and file systems. Understanding the implementation and operations of binary trees is essential for effective data management and manipulation in software development. The provided C# examples illustrate the core concepts and operations of binary trees, offering a solid foundation for tackling complex hierarchical data problems.