# consoleapp6
Creating the list: List<string> items = new List<string> { "A", "B", "C", "D", "C" }; - Initializes a list of strings containing some duplicate values.

Initializing a HashSet: HashSet<string> seenItems = new HashSet<string>(); - This is used to store items we've already encountered, which helps in identifying duplicates.

Foreach loop to iterate: The loop goes through each string in the list to check if it has been seen before.

Duplicate check: if (seenItems.Contains(item)) - Checks if the current item has already been added to the set. If it has, it's a duplicate.

Printing duplicate or unique message: Based on whether the item has been seen before, it prints either "unique" or "duplicate."

Adding unique items: If the item hasn't been seen before, it’s added to seenItems to mark it as encountered.
