using System.Collections;                         // Required to use ArrayList

ArrayList array = new ArrayList();                // Create an ArrayList object

array.Add(10);                                    // Add an integer value to the ArrayList
array.Add("Junayed Islam");                       // Add a string value to the ArrayList
array.Add(34.7);                                  // Add a double value to the ArrayList
array.Add("Hello");                               // Add another string value to the ArrayList

foreach (var item in array)                       // Read each item from the ArrayList
{
    Console.WriteLine(item);                      // Print each item
}

Console.WriteLine("After Remove: ");              // Print message before showing updated ArrayList

array.Remove("Hello");                            // Remove the value "Hello" from the ArrayList
array.RemoveAt(1);                                // Remove the item at index 1

foreach (var item in array)                       // Read each remaining item from the ArrayList
{
    Console.WriteLine(item);                      // Print each remaining item
}

List<string> names = new List<string>();          // Create a List that can store only string values

names.Add("Junayed");                             // Add "Junayed" to the List
names.Add("Sifat");                               // Add "Sifat" to the List
names.Add("Alif");                                // Add "Alif" to the List
names.Add("Fatime");                              // Add "Fatime" to the List

foreach (var value in names)                      // Read each name from the List
{
    Console.WriteLine(value);                     // Print each name
}

Console.ReadKey();                                // Wait for a key press before closing the console