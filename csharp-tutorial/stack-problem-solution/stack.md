# Stack Data Structure Tutorial

## Navigation

1. [Start Solving](stack-problem.cs)
2. [Go Back](../../README.md)
3. [Outline](../outline.md)

## 1. Introduction to Stack

A stack is a linear data structure that operates on a Last In, First Out (LIFO) principle. This means that the last element added to the stack will be the first one to be removed. Stacks are used in various scenarios including function call management, expression evaluation, and undo mechanisms.

Please make sure to read the comments I made on the code, these will help you to better understand what is happening.

## 2. Key Operations of Stack

Stacks support the following key operations:
1. **Push:** Adds an element to the top of the stack.
2. **Pop:** Removes and returns the top element of the stack.
3. **Peek:** Returns the top element without removing it.
4. **IsEmpty:** Checks if the stack is empty.
5. **Size:** Returns the number of elements in the stack.

## 3. Big O Notation for Stack Operations

- **Push:** O(1) - Constant time operation as adding an element takes the same time regardless of the size of the stack.
- **Pop:** O(1) - Constant time operation as removing an element also takes the same time regardless of the size of the stack.
- **Peek:** O(1) - Constant time operation to view the top element.
- **IsEmpty:** O(1) - Constant time operation to check if the stack is empty.
- **Size:** O(1) - Constant time operation to retrieve the number of elements.

## 4. Implementing a Stack in C#

Below is a simple implementation of a stack using a list in C#:

```csharp
using System;
using System.Collections.Generic;

public class Stack<T>
{
    private List<T> elements = new List<T>();

    // Push method adds an element to the top of the stack
    public void Push(T item)
    {
        elements.Add(item);
    }

    // Pop method removes and returns the top element of the stack
    public T Pop()
    {
        if (IsEmpty())
            throw new InvalidOperationException("The stack is empty.");
        
        T value = elements[elements.Count - 1];
        elements.RemoveAt(elements.Count - 1);
        return value;
    }

    // Peek method returns the top element without removing it
    public T Peek()
    {
        if (IsEmpty())
            throw new InvalidOperationException("The stack is empty.");
        
        return elements[elements.Count - 1];
    }

    // IsEmpty method checks if the stack is empty
    public bool IsEmpty()
    {
        return elements.Count == 0;
    }

    // Size method returns the number of elements in the stack
    public int Size()
    {
        return elements.Count;
    }
}

public class Program
{
    public static void Main()
    {
        // Create a stack instance for integers
        Stack<int> stack = new Stack<int>();
        
        // Push elements onto the stack
        stack.Push(10);
        stack.Push(20);
        stack.Push(30);
        
        // Display the top element using Peek
        Console.WriteLine("Top element is: " + stack.Peek());
        
        // Pop elements from the stack
        Console.WriteLine("Popped element is: " + stack.Pop());
        Console.WriteLine("Popped element is: " + stack.Pop());
        
        // Check if the stack is empty
        Console.WriteLine("Is the stack empty? " + stack.IsEmpty());
        
        // Display the size of the stack
        Console.WriteLine("Stack size is: " + stack.Size());
    }
}
```
### Conclusion

Stacks are versatile and widely used data structures that follow the LIFO principle. Understanding how to implement and use stacks is crucial for solving various computational problems and optimizing application performance. The provided C# examples should give you a solid foundation to start working with stacks in your projects.