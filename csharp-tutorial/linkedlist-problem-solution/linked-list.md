# Linked List Data Structure Tutorial

## Navigation

1. [Start Solving](linked-list-problem.cs)
2. [Go Back](../../README.md)
3. [Outline](../outline.md)

## Introduction

A **Linked List** is a fundamental data structure where each element, known as a node, contains a value and a reference (link) to the next node in the sequence. Unlike arrays, linked lists do not require contiguous memory allocation, allowing for efficient insertion and deletion operations.

### Real-World Example: Music Playlist

Consider a music playlist application where each song can be dynamically added or removed. A linked list is a suitable data structure for this scenario because it allows you to efficiently add new songs to the playlist (either at the beginning or end) and remove songs without the need to shift other elements. Each song (node) in the playlist contains a reference to the next song, allowing for easy navigation through the playlist.

## When to Use a Linked List

Linked lists are suitable when you need a dynamic data structure that allows efficient insertions and deletions. Here are some scenarios where using a linked list is beneficial:

1. **Dynamic Memory Allocation**: Linked lists are ideal when the number of elements is not known in advance or when you expect frequent insertions and deletions. They avoid the overhead of resizing and copying that occurs with arrays.

2. **Implementing Queues and Stacks**: Linked lists can be used to implement queues and stacks. Their ability to efficiently add and remove elements from both ends makes them a good choice for these data structures.

3. **Memory-Constrained Environments**: In environments where memory is fragmented or limited, linked lists allow for efficient use of memory without needing contiguous blocks.

4. **Sparse Data Structures**: Linked lists are useful for representing sparse matrices or other data structures where most elements are zero or empty. Each non-zero element can be stored in a node with a reference to its position.

5. **Adjacency Lists in Graphs**: Linked lists are often used to represent adjacency lists in graph data structures, where each node maintains a list of its adjacent nodes.

### Example Scenario

Consider a music playlist application where users can add and remove songs. Using a linked list allows you to efficiently manage the playlist, as you can add or remove songs without needing to shift other elements, unlike in an array.

## Components of a Linked List

| Component    | Description                                           |
|--------------|-------------------------------------------------------|
| **Node**     | Represents an element in the list. Contains data and a link to the next node. |
| **Head**     | The first node in the linked list.                   |
| **Tail**     | The last node in the linked list (optional).          |
| **Size**     | The number of nodes in the linked list.               |

## Basic Operations

1. **Insertion**: Adding a new node to the linked list, either at the beginning, end, or a specific position.
2. **Deletion**: Removing a node from the linked list, which can be the first, last, or a specific node.
3. **Traversal**: Accessing each node in the list, usually starting from the head and moving to the next node.
4. **Search**: Finding a node with a specific value by traversing through the list.

## Advantages of Linked Lists

- **Dynamic Size**: The size of a linked list can grow or shrink dynamically as nodes are added or removed, which provides flexibility in memory usage.
- **Efficient Insertions/Deletions**: Inserting or deleting nodes in a linked list is more efficient than in an array, especially when dealing with large datasets, because it does not require shifting elements.

## Disadvantages of Linked Lists

- **Memory Usage**: Linked lists require extra memory for storing references (pointers) along with the actual data.
- **Traversal Time**: Accessing an element in a linked list takes O(n) time, as it requires traversing from the head to the desired node, unlike arrays which provide O(1) access time.

## Types of Linked Lists

1. **Singly Linked List**: Each node contains a reference to the next node, forming a one-way chain.
2. **Doubly Linked List**: Each node contains references to both the next and previous nodes, allowing traversal in both directions.
3. **Circular Linked List**: The last node points back to the first node, forming a circular chain, which can be useful for applications that require a cyclic iteration.

## Example Implementation in C#

Below is a simple implementation of a singly linked list in C#:

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

    // Find a node with a specific value
    public Node Find(int value)
    {
        Node current = head;
        while (current != null)
        {
            if (current.Data == value)
                return current;
            current = current.Next;
        }
        return null; // Value not found
    }

    // Remove a node with a specific value
    public void Remove(int value)
    {
        if (head == null)
            throw new InvalidOperationException("The list is empty.");

        if (head.Data == value)
        {
            head = head.Next;
            size--;
            return;
        }

        Node current = head;
        while (current.Next != null)
        {
            if (current.Next.Data == value)
            {
                current.Next = current.Next.Next;
                size--;
                return;
            }
            current = current.Next;
        }

        throw new InvalidOperationException("Value not found in the list.");
    }
}

public class Program
{
    public static void Main()
    {
        LinkedList list = new LinkedList();

        // Adding elements to the list
        list.AddFirst(10);
        list.AddLast(20);
        list.AddLast(30);

        // Display the list
        list.Display();

        // Remove the first element
        list.RemoveFirst();
        list.Display();

        // Find a node with a specific value
        Node foundNode = list.Find(20);
        Console.WriteLine(foundNode != null ? $"Found: {foundNode.Data}" : "Not Found");

        // Remove a node with a specific value
        list.Remove(20);
        list.Display();
    }
}
```
## Real-World Problem: Managing a Playlist

Imagine you are developing a music playlist application where users can add, remove, and reorder songs. Using a linked list allows you to efficiently add new songs to the beginning or end of the playlist and remove songs without shifting other elements. Here's how you might use a linked list for this:

1. Add a Song: When a user adds a song to the playlist, you can insert it at the end of the list using AddLast.
2. Remove a Song: To remove a song, you can search for the song by its title and then use Remove to delete it from the list.
3. Display Playlist: Use Display to show all songs in the playlist in the order they were added.

## Conclusion

Linked lists are a versatile and dynamic data structure that provides efficient insertion and deletion operations compared to arrays. Understanding linked lists is crucial for solving problems that involve dynamic data management, such as implementing playlists or other sequential data structures. The provided C# examples demonstrate how to implement and use linked lists effectively, offering a solid foundation for tackling various computational challenges.