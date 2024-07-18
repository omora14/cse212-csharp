# Linked List Example

## Introduction

A **Linked List** is a fundamental data structure where each element (node) contains a value and a reference (link) to the next node in the sequence. Unlike arrays, linked lists do not require contiguous memory allocation, allowing for efficient insertion and deletion operations.

## Components of a Linked List

| Component    | Description                                           |
|--------------|-------------------------------------------------------|
| **Node**     | Represents an element in the list. Contains data and a link to the next node. |
| **Head**     | The first node in the linked list.                   |
| **Tail**     | The last node in the linked list (optional).          |
| **Size**     | The number of nodes in the linked list.               |

## Basic Operations

1. **Insertion**: Adding a new node to the linked list.
2. **Deletion**: Removing a node from the linked list.
3. **Traversal**: Accessing each node in the list, usually starting from the head.
4. **Search**: Finding a node with a specific value.

## Example Implementation in C#

```csharp
// Node class representing an element in the linked list
public class Node
{
    public int Data { get; set; } // Value of the node
    public Node Next { get; set; } // Reference to the next node

    // Constructor to initialize a node with data and an optional reference to the next node
    public Node(int data, Node next = null)
    {
        Data = data;
        Next = next;
    }
}

// LinkedList class implementing basic operations
public class LinkedList
{
    private Node head; // Reference to the first node in the list
    private int size;  // Number of nodes in the list

    // Constructor to initialize an empty linked list
    public LinkedList()
    {
        head = null;
        size = 0;
    }

    // Add a new node at the beginning of the list
    public void AddFirst(int data)
    {
        Node newNode = new Node(data, head); // Create a new node pointing to the current head
        head = newNode; // Update the head to the new node
        size++; // Increase the size of the list
    }

    // Add a new node at the end of the list
    public void AddLast(int data)
    {
        if (head == null)
        {
            AddFirst(data); // If list is empty, add as the first node
            return;
        }

        Node current = head;
        while (current.Next != null) // Traverse to the last node
        {
            current = current.Next;
        }

        current.Next = new Node(data); // Add the new node at the end
        size++; // Increase the size of the list
    }

    // Remove the first node from the list
    public void RemoveFirst()
    {
        if (head == null)
            throw new InvalidOperationException("The list is empty.");

        head = head.Next; // Update the head to the next node
        size--; // Decrease the size of the list
    }

    // Traverse and display the list
    public void Display()
    {
        Node current = head;
        while (current != null) // Traverse from the head to the end
        {
            Console.Write(current.Data + " -> "); // Display the node data
            current = current.Next; // Move to the next node
        }
        Console.WriteLine("null"); // Indicate the end of the list
    }

    // Get the size of the list
    public int Size()
    {
        return size;
    }
}
