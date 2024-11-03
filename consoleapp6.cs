using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Step 1: Create a list of strings with at least two identical items.
        List<string> items = new List<string> { "A", "B", "C", "D", "C" };
        
        // Step 2: Create a HashSet to keep track of unique items seen so far.
        HashSet<string> seenItems = new HashSet<string>();

        // Step 3: Iterate through each item in the list using a foreach loop.
        foreach (string item in items)
        {
            // Step 4: Check if the item has already appeared in the list.
            if (seenItems.Contains(item))
            {
                // Step 5: If the item is a duplicate, print a message indicating it's a duplicate.
                Console.WriteLine($"{item} - this item is a duplicate");
            }
            else
            {
                // Step 6: If the item is unique, add it to the set and print a message indicating it's unique.
                Console.WriteLine($"{item} - this item is unique");
                seenItems.Add(item);
            }
        }

        // Save the code and execute it to verify the output matches expectations.
    }
}