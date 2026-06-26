using System.Collections;                         // Required for non-generic Stack

Stack<int> st = new Stack<int>();                 // Create a generic Stack that stores only integer values

st.Push(5);                                       // Add 5 to the top of the stack
st.Push(6);                                       // Add 6 to the top of the stack
st.Push(7);                                       // Add 7 to the top of the stack
st.Push(8);                                       // Add 8 to the top of the stack

foreach (var item in st)                          // Read each item from the stack
{
    Console.Write(item + " ");                    // Print each item with a space
}

Console.WriteLine("");                           // Move to a new line
Console.WriteLine("After pop the: ");             // Print message before removing an item

st.Pop();                                         // Remove the top item from the stack

foreach (var item in st)                          // Read each remaining item from the stack
{
    Console.Write(item + " ");                    // Print each remaining item with a space
}

Stack mystack = new Stack();                      // Create a non-generic Stack that can store different data types

mystack.Push("Junayed");                          // Add a string value to the stack
mystack.Push(100);                                // Add an integer value to the stack
mystack.Push(50.75);                              // Add a double value to the stack

Console.WriteLine("");                           // Move to a new line

foreach (var item in mystack)                     // Read each item from the non-generic stack
{
    Console.Write(item + " ");                    // Print each item with a space
}