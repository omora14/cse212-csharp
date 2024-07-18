using System;

namespace LinkedListProblem
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

    // LinkedList class with basic operations
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

        // Problem: Implement a method to add a node at a specific index
        public void AddAt(int index, int data)
        {
            // TODO: Implement this method
            // 1. Check if the index is valid (0 <= index <= size).
            // 2. Traverse the list to the node just before the desired index.
            // 3. Insert the new node at the specified index.
            // 4. Update the links and size of the list.

            // For now, throw an exception to indicate that the method is not implemented
            throw new NotImplementedException("AddAt method is not yet implemented.");
        }

        // Display the list (for testing purposes)
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

        // Main method to test the problem
        public static void Main()
        {
            LinkedList list = new LinkedList();
            list.AddFirst(10);
            list.AddFirst(20);
            list.AddLast(30);
            list.Display(); // Output: 20 -> 10 -> 30 -> null

            // TODO: Test the AddAt method here after implementing it
        }
    }
}
