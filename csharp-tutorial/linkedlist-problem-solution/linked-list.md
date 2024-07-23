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

## Real-World Problem: Managing a Playlist

Imagine you are developing a music playlist application where users can add, remove, and reorder songs. Using a linked list allows you to efficiently manage the playlist, as you can add or remove songs without needing to shift other elements, unlike in an array.

### Example Implementation in C#

**I will be using code as examples, please make sure you read the comments I have added in the code, this can be identify because of its green letters or the two slashes (//) before every sentence**


Below is a simple implementation of a singly linked list in C# tailored to manage a music playlist with detailed explanations for better understanding:

```csharp
// Node class representing a song in the playlist
public class Song
{
    public string Title { get; set; } // Title of the song
    public Song Next { get; set; } // Reference to the next song

    // Constructor to initialize a song with a title and an optional reference to the next song
    public Song(string title, Song next = null)
    {
        Title = title;
        Next = next;
    }
}

// Playlist class implementing basic operations for managing a music playlist
public class Playlist
{
    private Song head; // Reference to the first song in the playlist
    private int size;  // Number of songs in the playlist

    // Constructor to initialize an empty playlist
    public Playlist()
    {
        head = null;
        size = 0;
    }

    // Add a new song at the beginning of the playlist
    public void AddFirst(string title)
    {
        Song newSong = new Song(title, head); // Create a new song pointing to the current head
        head = newSong; // Update the head to the new song
        size++; // Increase the size of the playlist
    }

    // Add a new song at the end of the playlist
    public void AddLast(string title)
    {
        if (head == null)
        {
            AddFirst(title); // If playlist is empty, add as the first song
            return;
        }

        Song current = head;
        while (current.Next != null) // Traverse to the last song
        {
            current = current.Next;
        }

        current.Next = new Song(title); // Add the new song at the end
        size++; // Increase the size of the playlist
    }

    // Remove the first song from the playlist
    public void RemoveFirst()
    {
        if (head == null)
            throw new InvalidOperationException("The playlist is empty.");

        head = head.Next; // Update the head to the next song
        size--; // Decrease the size of the playlist
    }

    // Display the playlist
    public void Display()
    {
        Song current = head;
        while (current != null) // Traverse from the head to the end
        {
            Console.Write(current.Title + " -> "); // Display the song title
            current = current.Next; // Move to the next song
        }
        Console.WriteLine("null"); // Indicate the end of the playlist
    }

    // Get the size of the playlist
    public int Size()
    {
        return size;
    }

    // Find a song with a specific title
    public Song Find(string title)
    {
        Song current = head;
        while (current != null)
        {
            if (current.Title == title)
                return current;
            current = current.Next;
        }
        return null; // Title not found
    }

    // Remove a song with a specific title
    public void Remove(string title)
    {
        if (head == null)
            throw new InvalidOperationException("The playlist is empty.");

        if (head.Title == title)
        {
            head = head.Next;
            size--;
            return;
        }

        Song current = head;
        while (current.Next != null)
        {
            if (current.Next.Title == title)
            {
                current.Next = current.Next.Next;
                size--;
                return;
            }
            current = current.Next;
        }

        throw new InvalidOperationException("Song not found in the playlist.");
    }
}

public class Program
{
    public static void Main()
    {
        Playlist playlist = new Playlist();

        // Adding songs to the playlist
        playlist.AddFirst("Song 1");
        playlist.AddLast("Song 2");
        playlist.AddLast("Song 3");

        // Display the playlist
        playlist.Display();

        // Remove the first song
        playlist.RemoveFirst();
        playlist.Display();

        // Find a song with a specific title
        Song foundSong = playlist.Find("Song 2");
        Console.WriteLine(foundSong != null ? $"Found: {foundSong.Title}" : "Not Found");

        // Remove a song with a specific title
        playlist.Remove("Song 2");
        playlist.Display();
    }
}
```

# Conclusion

Linked lists are a versatile and dynamic data structure that provides efficient insertion and deletion operations compared to arrays. Understanding linked lists is crucial for solving problems that involve dynamic data management, such as implementing and managing a music playlist.