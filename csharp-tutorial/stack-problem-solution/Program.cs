// Program.cs

using System;
using System.Collections.Generic;

public class Book
{
    public string Title { get; }
    public string Author { get; }

    // Constructor to initialize the book properties
    public Book(string title, string author)
    {
        Title = title;
        Author = author;
    }

    // Override ToString method to provide a string representation of the book
    public override string ToString()
    {
        return $"\"{Title}\" by {Author}";
    }
}

public class BookStack
{
    private Stack<Book> stack = new Stack<Book>();

    // Push a book onto the stack
    public void PushBook(Book book)
    {
        stack.Push(book);
    }

    // Pop a book from the stack
    public Book PopBook()
    {
        if (IsEmpty())
            throw new InvalidOperationException("The stack is empty.");
        
        return stack.Pop();
    }

    // Peek at the top book of the stack
    public Book PeekBook()
    {
        if (IsEmpty())
            throw new InvalidOperationException("The stack is empty.");
        
        return stack.Peek();
    }

    // Check if the stack is empty
    public bool IsEmpty()
    {
        return stack.Count == 0;
    }

    // Return the number of books in the stack
    public int Size()
    {
        return stack.Count;
    }
}

public class Program
{
    public static void Main()
    {
        // Create a BookStack instance
        BookStack bookStack = new BookStack();
        
        // Create book instances
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald");
        Book book2 = new Book("To Kill a Mockingbird", "Harper Lee");
        Book book3 = new Book("1984", "George Orwell");
        
        // Push books onto the stack
        bookStack.PushBook(book1);
        bookStack.PushBook(book2);
        bookStack.PushBook(book3);
        
        // Display the top book using PeekBook
        Console.WriteLine("Top book is: " + bookStack.PeekBook());
        
        // Pop books from the stack
        Console.WriteLine("Popped book is: " + bookStack.PopBook());
        Console.WriteLine("Popped book is: " + bookStack.PopBook());
        
        // Check if the stack is empty
        Console.WriteLine("Is the stack empty? " + bookStack.IsEmpty());
        
        // Display the number of books in the stack
        Console.WriteLine("Stack size is: " + bookStack.Size());
    }
}
