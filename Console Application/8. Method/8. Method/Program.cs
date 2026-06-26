// Call the Add method with 40 and 60
// The returned result will be stored in the result variable
int result = Add(40, 60);

// Print the value of result
Console.WriteLine(result);

// Call the Greeting method and send "Hello World" as an argument
Greeting("Hello World");


// This method takes two integer numbers as parameters
// Then it adds them and returns the result
static int Add(int a, int b)
{
    int c = a + b;   // Add a and b, then store the answer in c
    return c;        // Return the value of c
}


// This method takes one string value as a parameter
// It only prints the string, so the return type is void
static void Greeting(string s)
{
    Console.WriteLine(s);   // Print the value of s
}