Dictionary<int, string> dic = new Dictionary<int, string>();     // Create a Dictionary with int key and string value

dic.Add(1, "Rahim");                                             // Add key 1 with value "Rahim"
dic.Add(2, "Karim");                                             // Add key 2 with value "Karim"
dic.Add(3, "Fahim");                                             // Add key 3 with value "Fahim"
dic.Add(4, "Rasel");                                             // Add key 4 with value "Rasel"

foreach (var data in dic)                                        // Loop through each key-value pair in the dictionary
{
    Console.WriteLine(data);                                     // Print the full key-value pair
}

foreach (var data in dic)                                        // Loop through the dictionary again
{
    Console.WriteLine("Key: " + data.Key + ", " + "Value: " + data.Value); // Print key and value separately
}

Console.Write("Enter the key number for search the value: ");    // Ask user to enter a key number

int keyNum = Convert.ToInt32(Console.ReadLine());                 // Take input from user and convert it to integer

string name;                                                      // Declare a string variable to store the found value

if (dic.TryGetValue(keyNum, out name))                            // Check if the key exists in the dictionary
{
    Console.WriteLine("Data Found: " + name);                     // If key exists, print the value
}
else
{
    Console.WriteLine("Not Found");                               // If key does not exist, print Not Found
}

Console.ReadKey();                                                // Wait for a key press before closing the console