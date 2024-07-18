using System;

namespace LinkedListSolution
{
    // Node class representing an element in the linked list
    public class Node
    {
        public int Data { get; set; } // Value of the node
        public Node Next { get; set; } // Reference to the next node

        public Node(int data, Node next = null)
        {
            Data = data;
            Next = next;
        }
    }

    // LinkedList class with basic operations and the AddAt method implemented
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

        // Implementing the method to add a node at a specific index
        public void AddAt(int index, int data)
        {
            if (index < 0 || index > size)
                throw new ArgumentOutOfRangeException("Index out of range.");

            if (index == 0)
            {
                AddFirst(data); // Add at the beginning if index is 0
                return;
            }

            Node current = head;
            for (int i = 1; i < index; i++) // Traverse to the node just before the desired index
            {
                current = current.Next;
            }

            Node newNode = new Node(data, current.Next); // Create new node pointing to the next node
            current.Next = newNode; // Update the previous node's next reference to the new node
            size++; // Increase the size of the list
        }

        // Add a new node at the beginning of the list
        public void AddFirst(int data)
        {
            Node newNode = new Node(data, head);
            head = newNode;
            size++;
        }

        // Add a new node at the end of the list
        public void AddLast(int data)
        {
            if (head == null)
            {
                AddFirst(data);
                return;
            }

            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }

            current.Next = new Node(data);
            size++;
        }

        // Display the list
        public void Display()
        {
            Node current = head;
            while (current != null)
            {
                Console.Write(current.Data + " -> ");
                current = current.Next;
            }
            Console.WriteLine("null");
        }

        // Get the size of the list
        public int Size()
        {
            return size;
        }

        // Main method to test the implemented AddAt method
        public static void Main()
        {
            LinkedList list = new LinkedList();
            list.AddFirst(10);
            list.AddFirst(20);
            list.AddLast(30);
            list.Display(); // Output: 20 -> 10 -> 30 -> null

            // Testing the AddAt method
            list.AddAt(1, 15); // Adding 15 at index 1
            list.Display(); // Output: 20 -> 15 -> 10 -> 30 -> null
            Console.WriteLine("Size: " + list.Size()); // Output: Size: 4
        }
    }
}
