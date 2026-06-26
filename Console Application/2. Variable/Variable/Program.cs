// Declare a string variable named message and store a text value in it
string message = "Hello! How are you?";

// Print the value of the message variable on the console
Console.WriteLine(message);

// Change/update the value of the message variable
message = "Junayed Islam";

// Print the updated value of the message variable
Console.WriteLine(message);

// Declare another string variable named message2 and store a text value in it
// There is a space before "Jadir", so a space will appear when it is joined
string message2 = " Jadir";

// Join message and message2 together and print the result
Console.WriteLine(message + message2);

// Declare a string variable named message3
// Environment.NewLine is used to move the text to a new line
string message3 = "I am learning ASP.NET " + Environment.NewLine + "from today.";

// Print the value of message3 on the console
Console.WriteLine(message3);

// Declare an integer variable named num and store the value 10
int num = 10;

// Add 20 with num and print the result
Console.WriteLine(num + 20);

// Here, "Result: " is a string
// So num and 20 will be joined as text, not added mathematically
// Output: Result: 1020
Console.WriteLine("Result: " + num + 20);

// Here, num + 20 is inside parentheses
// So the calculation will happen first
// Then the result will be joined with "Result: "
// Output: Result: 30
Console.WriteLine("Result: " + (num + 20));

// Declare an integer variable named result
// Store the result of num + 30 in it
int result = num + 30;

// Print the text "Result: " with the value of result
Console.WriteLine("Result: " + result);

// Wait for the user to press Enter before closing the console window
Console.ReadLine();