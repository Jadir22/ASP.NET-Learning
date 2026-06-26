using System.Collections;                                      // Required to use Hashtable

Hashtable ht = new Hashtable();                               // Create a Hashtable object

ht.Add("1", "One");                                           // Add a string key "1" with string value "One"
ht.Add(2, "Two");                                             // Add an integer key 2 with string value "Two"
ht.Add(3, 3);                                                 // Add an integer key 3 with integer value 3
ht.Add(3.3, 39.5);                                            // Add a double key 3.3 with double value 39.5

foreach (DictionaryEntry data in ht)                          // Loop through each key-value pair in the Hashtable
{
    Console.WriteLine(data);                                  // Print the full key-value pair
}

Console.WriteLine("Print Key and Value Separately:");         // Print a message before showing key and value

foreach (DictionaryEntry data in ht)                          // Loop through the Hashtable again
{
    Console.WriteLine("Key: " + data.Key + ", Value: " + data.Value); // Print key and value separately
}

Console.Write("Enter a key for search the value: ");          // Ask user to enter a key

string key = Console.ReadLine();                              // Take user input as string

if (ht.ContainsKey(key))                                      // Check if the given key exists in the Hashtable
{
    Console.WriteLine("Data Found: " + ht[key]);              // If key exists, print the value
}
else
{
    Console.WriteLine("Not Found");                           // If key does not exist, print Not Found
}

Console.ReadKey();                                           // Wait for a key press before closing the console