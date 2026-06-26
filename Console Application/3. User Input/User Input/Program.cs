string msg = Console.ReadLine();              // Take input from user and store it in msg
Console.WriteLine("Hello " + msg);            // Print Hello with the user's input

Console.Write("Enter the 1st number: ");      // Ask user to enter first number
int a = Convert.ToInt32(Console.ReadLine());  // Take input and convert it to integer

Console.Write("Enter the 2nd number: ");      // Ask user to enter second number
int b = Convert.ToInt32(Console.ReadLine());  // Take input and convert it to integer

int sum = a + b;                              // Add a and b, then store the result in sum

Console.WriteLine(a + " + " + b + " : " + sum); // Print the addition result

char ch = 'a';                                // Declare a character variable
int asccii = ch;                              // Convert character to its ASCII value
Console.WriteLine(asccii);                   // Print the ASCII valueS