using System.Collections;                         // Required for non-generic Queue

Queue<int> q = new Queue<int>();                  // Create a generic Queue that stores only integer values

q.Enqueue(5);                                     // Add 5 to the queue
q.Enqueue(6);                                     // Add 6 to the queue
q.Enqueue(7);                                     // Add 7 to the queue
q.Enqueue(8);                                     // Add 8 to the queue

foreach (var item in q)                           // Read each item from the queue
{
    Console.Write(item + " ");                    // Print each item with a space
}

Console.WriteLine("");                           // Move to a new line
Console.WriteLine("After dequeue: ");             // Print message before removing an item

q.Dequeue();                                      // Remove the first item from the queue

foreach (var item in q)                           // Read each remaining item from the queue
{
    Console.Write(item + " ");                    // Print each remaining item with a space
}

Queue myqueue = new Queue();                      // Create a non-generic Queue that can store different data types

myqueue.Enqueue("Junayed");                       // Add a string value to the queue
myqueue.Enqueue(100);                             // Add an integer value to the queue
myqueue.Enqueue(50.75);                           // Add a double value to the queue

Console.WriteLine("");                           // Move to a new line

foreach (var item in myqueue)                     // Read each item from the non-generic queue
{
    Console.Write(item + " ");                    // Print each item with a space
}