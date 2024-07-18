@author Owen Morale
    @since 7/18/2024

// Problem Description:
// You are tasked with creating a basic stack-based application to manage a stack of books. Each book has a title and an author.
// Implement a stack to manage these books and perform the following operations:
//
// 1. Push a Book - Add a book to the top of the stack.
// 2. Pop a Book - Remove and return the book from the top of the stack.
// 3. Peek at the Top Book - Return the book from the top of the stack without removing it.
// 4. Check if the Stack is Empty - Determine if the stack has no books.
// 5. Display the Number of Books - Show the total number of books currently in the stack.
//
// Instructions:
//
// 1. **Create a `Book` Class**:
//    - Properties: `Title` (string), `Author` (string)
//    - Constructor to initialize these properties
//
// 2. **Implement a `BookStack` Class**:
//    - This class should use the provided `Stack<T>` implementation.
//    - Create methods for the stack operations:
//        - `PushBook(Book book)`
//        - `PopBook()`
//        - `PeekBook()`
//        - `IsEmpty()`
//        - `Size()`
//
// 3. **Write a `Main` Method**:
//    - Demonstrate the usage of your `BookStack` class.
//    - Create a few `Book` instances and perform operations using `BookStack`.
//
// Example Output:
// The output should display the top book, popped books, stack status, and size information.
//
// Hints:
// - Use the `Push` method to add a `Book` to the stack.
// - Use the `Pop` method to remove the top book and check if the stack is empty.
// - Use the `Peek` method to view the top book without removing it.
// 
// Ensure your implementation is well-documented and follows the principles of the stack data structure.

using System;

public class Book
{
    // Define the properties
    public string Title { get; set; }
    public string Author { get; set; }

    // Constructor to initialize the properties
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    // Override ToString method for readable output
    public override string ToString()
    {
        return $"\"{Title}\" by {Author}";
    }
}

public class BookStack
{
    // Define your stack here using the provided Stack<T> implementation
    // ...

    // Implement methods for stack operations
    // e.g., PushBook, PopBook, PeekBook, IsEmpty, Size
    // ...
}

public class Program
{
    public static void Main()
    {
        // Create a BookStack instance
        // Demonstrate stack operations with Book instances
        // e.g., Push books, Pop books, Peek book, Check if empty, Display size
        // ...
    }
}
