using System;

namespace LinkedListExample
{
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

        // Main method to demonstrate LinkedList operations
        public static void Main()
        {
            LinkedList list = new LinkedList();
            list.AddFirst(10);
            list.AddFirst(20);
            list.AddLast(30);
            list.Display(); // Output: 20 -> 10 -> 30 -> null
            Console.WriteLine("Size: " + list.Size()); // Output: Size: 3

            list.RemoveFirst();
            list.Display(); // Output: 10 -> 30 -> null
            Console.WriteLine("Size: " + list.Size()); // Output: Size: 2
        }
    }
}
