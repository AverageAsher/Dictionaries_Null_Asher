using System;                  // Import the System namespace, which contains fundamental classes.
using System.Collections;      // Import the System.Collections namespace for using Hashtable.
using System.Collections.Generic; // Import the System.Collections.Generic namespace for using Dictionary.

namespace DictionaryAndHashtableExample  // Define a namespace to organize classes and prevent naming conflicts.
{
    class Program  // Define the Program class where the Main method resides.
    {
        static void Main(string[] args)  // The Main method is the entry point of the program.
        {
            // Create a dictionary that takes an int as the key and a string as the value.
            Dictionary<int, string> topGames = new Dictionary<int, string>();

            // Add your top ten favorite games to the dictionary, with the key being their placement.
            topGames.Add(1, "The Legend of Zelda: Breath of the Wild"); // Add game at position 1.
            topGames.Add(2, "God of War"); // Add game at position 2.
            topGames.Add(3, "Red Dead Redemption 2"); // Add game at position 3.
            topGames.Add(4, "The Witcher 3: Wild Hunt"); // Add game at position 4.
            topGames.Add(5, "Halo: Combat Evolved"); // Add game at position 5.
            topGames.Add(6, "Super Mario Odyssey"); // Add game at position 6.
            topGames.Add(7, "Minecraft"); // Add game at position 7.
            topGames.Add(8, "Fortnite"); // Add game at position 8.
            topGames.Add(9, "Overwatch"); // Add game at position 9.
            topGames.Add(10, "Grand Theft Auto V"); // Add game at position 10.

            // Loop through the topGames dictionary and print out each Key/Value pair on a new line.
            foreach (var game in topGames)  // Iterate through each key/value pair in the dictionary.
            {
                Console.WriteLine($"Key: {game.Key}, Value: {game.Value}"); // Print the key and value.
            }

            // Check if topGames contains key 1.
            if (topGames.ContainsKey(1))  // If key 1 exists in the dictionary.
            {
                Console.WriteLine($"My favorite game is: {topGames[1]}"); // Print the value at key 1.
            }

            // Create an empty string called result.
            string result = string.Empty;  // Initialize an empty string.

            // Implement the TryGetValue method on topGames for key 11.
            if (topGames.TryGetValue(11, out result))  // Attempt to get the value at key 11.
            {
                Console.WriteLine(result); // If successful, print the result.
            }
            else
            {
                Console.WriteLine("There is no game in the eleventh position."); // If not successful, print a message.
            }

            // Switch the dictionary entry object at key 5 with a new game title you also enjoy.
            if (topGames.ContainsKey(5))  // Check if key 5 exists in the dictionary.
            {
                topGames[5] = "Dark Souls III"; // Change the value at key 5 to a new game title.
            }

            // Print the new value at key 5.
            Console.WriteLine($"New game at position 5: {topGames[5]}"); // Print the updated value at key 5.

            // Create a new Hashtable and set it equal to topGames.
            Hashtable gamesHashtable = new Hashtable(topGames);  // Initialize a Hashtable with the topGames dictionary.

            // Create a string called favGame.
            string favGame = string.Empty;  // Initialize an empty string for the favorite game.

            // Set favGame to the value of key 1 in the hashtable you just created.
            favGame = (string)gamesHashtable[1];  // Retrieve the value at key 1 and cast it to a string.

            // Print favGame to console.
            Console.WriteLine($"Favorite game from Hashtable: {favGame}"); // Print the favorite game.

            // Create another hashtable using collection-initializer syntax, called capitals.
            Hashtable capitals = new Hashtable  // Initialize a new Hashtable with state capitals.
            {
                { "California", "Sacramento" }, // Add state and capital pair.
                { "Texas", "Austin" },          // Add state and capital pair.
                { "New York", "Albany" },       // Add state and capital pair.
                { "Florida", "Tallahassee" }    // Add state and capital pair.
            };

            // Loop through the capitals hashtable and print out the DictionaryEntry objects key and value on a new line.
            foreach (DictionaryEntry entry in capitals)  // Iterate through each entry in the Hashtable.
            {
                Console.WriteLine($"Key: {entry.Key}, Value: {entry.Value}"); // Print the key and value.
            }

            // Clear all elements in the capitals hashtable.
            capitals.Clear();  // Remove all elements from the Hashtable.
        }
    }
}
