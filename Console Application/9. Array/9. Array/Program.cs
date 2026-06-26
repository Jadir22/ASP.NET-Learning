int[] numbers = new int[5];                         // Create an integer array with size 5

numbers[0] = 5;                                     // Store 5 at index 0
numbers[1] = 10;                                    // Store 10 at index 1
numbers[2] = 15;                                    // Store 15 at index 2
numbers[3] = 20;                                    // Store 20 at index 3
numbers[4] = 30;                                    // Store 30 at index 4

for (int i = 0; i < numbers.Length; i++)            // Loop from index 0 to the last index of the array
{
    Console.Write(numbers[i] + " ");                // Print each array element with a space
}

Console.WriteLine(" ");                             // Print a new line

Console.WriteLine("Using for each loop");           // Print a message before using foreach loop

foreach (var data in numbers)                       // Read each value from the numbers array one by one
{
    Console.Write(data + " ");                      // Print each value with a space
}

Console.WriteLine(" ");                             // Print a new line

// Take data from user
int size = Convert.ToInt32(Console.ReadLine());      // Take array size from user and convert it to integer

int[] array = new int[size];                         // Create a new integer array using user-given size

for (int i = 0; i < size; i++)                       // Loop to take input for each array index
{
    array[i] = Convert.ToInt32(Console.ReadLine());  // Take input from user and store it in the array
}

foreach (var data in array)                          // Read each value from the user input array
{
    Console.Write(data + " ");                      // Print each value with a space
}

int sum = 0;                                         // Create a variable to store the sum of numbers array

foreach (var data in numbers)                        // Read each value from the numbers array
{
    sum += data;                                     // Add each value to sum
}

Console.WriteLine(" ");                             // Print a new line
Console.WriteLine("Sum: " + sum);                   // Print the total sum of the numbers array

Console.ReadKey();                                  // Wait for a key press before closing the console