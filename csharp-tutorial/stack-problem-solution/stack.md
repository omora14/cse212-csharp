# Stack Data Structure Tutorial

## Navigation

1. [Start Solving](stack-problem.cs)
2. [Go Back](../../README.md)
3. [Outline](../outline.md)

## 1. Introduction to Stack

A stack is a linear data structure that operates on a Last In, First Out (LIFO) principle. This means that the last element added to the stack will be the first one to be removed. Stacks are used in various scenarios including function call management, expression evaluation, and undo mechanisms.

### Real-World Example: Browser History

Consider your web browser's history feature. Each time you visit a new page, the URL is pushed onto a stack. When you click the "Back" button, the most recent URL is popped off the stack, and you are taken to the previous page. This is a classic example of using a stack to manage a sequence of actions where the most recent action is the first to be reversed.

## When to Use a Stack

Stacks are ideal when you need to manage data in a Last In, First Out (LIFO) order. Here are some scenarios where using a stack is appropriate:

1. **Function Call Management**: Stacks are used to manage function calls and returns in programming languages. The call stack keeps track of function calls and local variables, allowing the program to return to the correct state after a function completes.

2. **Expression Evaluation**: In arithmetic and logical expressions, stacks can be used to evaluate postfix (Reverse Polish Notation) expressions efficiently. They are also useful for converting infix expressions to postfix expressions.

3. **Undo Mechanisms**: Applications often use stacks to implement undo features. Each action is pushed onto the stack, and undoing an action involves popping the most recent action off the stack.

4. **Backtracking Algorithms**: Stacks are used in algorithms that involve backtracking, such as depth-first search in graphs and solving puzzles like mazes and Sudoku.

5. **Parsing Expressions**: Stacks are employed in compilers and interpreters for parsing expressions and managing operator precedence.

### Example Scenario

Imagine you are designing a text editor that needs an undo feature. Each editing operation (e.g., typing a letter, deleting a word) is pushed onto a stack. When the user wants to undo an operation, the most recent operation is popped from the stack and reversed.


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

## Real-World Problem: Managing a Task List

Imagine you are developing a task management application where users can create a list of tasks to be completed. You want to implement an "undo" feature that allows users to revert their last action, such as adding or removing a task. You can use a stack to keep track of these actions.

Below is an example of how you might use a stack to manage this functionality:

```csharp
using System;
using System.Collections.Generic;

public class TaskManager
{
    private Stack<string> taskStack = new Stack<string>();

    // Add a task and push it onto the stack
    public void AddTask(string task)
    {
        taskStack.Push(task);
        Console.WriteLine($"Task added: {task}");
    }

    // Undo the last task addition
    public void Undo()
    {
        if (taskStack.Count == 0)
        {
            Console.WriteLine("No tasks to undo.");
            return;
        }
        string lastTask = taskStack.Pop();
        Console.WriteLine($"Task undone: {lastTask}");
    }

    // Display all tasks
    public void DisplayTasks()
    {
        Console.WriteLine("Current tasks:");
        foreach (var task in taskStack)
        {
            Console.WriteLine(task);
        }
    }
}

public class Program
{
    public static void Main()
    {
        TaskManager manager = new TaskManager();

        // Adding tasks
        manager.AddTask("Complete homework");
        manager.AddTask("Read a book");
        manager.AddTask("Go for a walk");

        // Display current tasks
        manager.DisplayTasks();

        // Undo the last task
        manager.Undo();

        // Display tasks after undo
        manager.DisplayTasks();
    }
}
```

## Conclusion

Stacks are versatile and widely used data structures that follow the LIFO principle. Understanding how to implement and use stacks is crucial for solving various computational problems and optimizing application performance. The provided C# examples illustrate how stacks can be applied in practical scenarios such as browser history management and task management with undo functionality. By using these examples, you can gain a deeper understanding of how stacks can be effectively utilized in real-world applications.