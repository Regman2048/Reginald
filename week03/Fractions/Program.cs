using System;
using System.Collections.Generic;
using System.Linq; // For .Any() and .All()

public class Program
{
    public static void Main(string[] args)
    {
        // Exceeding Requirement: Load scriptures from a file or use a simple library
        List<Scripture> scriptureLibrary = LoadScripturesFromFile("scriptures.txt");

        if (scriptureLibrary.Count == 0)
        {
            Console.WriteLine("No scriptures loaded. Using default scripture.");
            Reference defaultRef = new Reference("John", 3, 16);
            string defaultText = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
            scriptureLibrary.Add(new Scripture(defaultRef, defaultText));

            Reference defaultRef2 = new Reference("Proverbs", 3, 5, 6);
            string defaultText2 = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
            scriptureLibrary.Add(new Scripture(defaultRef2, defaultText2));
        }

        // Exceeding Requirement: Choose a random scripture from the library
        Random random = new Random();
        Scripture currentScripture = scriptureLibrary[random.Next(scriptureLibrary.Count)];

        string userInput = "";

        while (!currentScripture.IsCompletelyHidden() && userInput.ToLower() != "quit")
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine("\nPress Enter to hide more words or type 'quit' to exit: ");
            userInput = Console.ReadLine();

            if (userInput.ToLower() == "quit")
            {
                break;
            }
            else if (string.IsNullOrWhiteSpace(userInput))
            {
                // Exceeding Requirement: Hide a few random words that are not already hidden
                currentScripture.HideRandomWords(3); // Hide 3 words at a time
            }
            else
            {
                Console.WriteLine("Invalid input. Press Enter or type 'quit'.");
                System.Threading.Thread.Sleep(1000); // Pause briefly
            }
        }

        Console.Clear();
        Console.WriteLine(currentScripture.GetDisplayText()); // Final display with all words hidden
        Console.WriteLine("\nAll words hidden. Program ended.");
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    // Exceeding Requirement: Load scriptures from a file
    private static List<Scripture> LoadScripturesFromFile(string filePath)
    {
        List<Scripture> scriptures = new List<Scripture>();
        if (!File.Exists(filePath))
        {
            Console.WriteLine($"Scripture file '{filePath}' not found. Using default scriptures.");
            return scriptures;
        }

        try
        {
            string[] lines = File.ReadAllLines(filePath);
            foreach (string line in lines)
            {
                string[] parts = line.Split('|');
                if (parts.Length == 2)
                {
                    string referenceString = parts[0].Trim();
                    string text = parts[1].Trim();

                    Reference reference = ParseReferenceString(referenceString);
                    if (reference != null)
                    {
                        scriptures.Add(new Scripture(reference, text));
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error loading scriptures from file: {ex.Message}");
        }
        return scriptures;
    }

    private static Reference ParseReferenceString(string refString)
    {
        // Example: "John 3:16" or "Proverbs 3:5-6"
        string[] parts = refString.Split(' ');
        if (parts.Length < 2) return null;

        string book = parts[0];
        string chapterAndVerse = parts[1];

        string[] cvParts = chapterAndVerse.Split(':');
        if (cvParts.Length != 2) return null;

        if (!int.TryParse(cvParts[0], out int chapter)) return null;

        string[] verseParts = cvParts[1].Split('-');
        if (verseParts.Length == 1)
        {
            if (int.TryParse(verseParts[0], out int verse))
            {
                return new Reference(book, chapter, verse);
            }
        }
        else if (verseParts.Length == 2)
        {
            if (int.TryParse(verseParts[0], out int startVerse) && int.TryParse(verseParts[1], out int endVerse))
            {
                return new Reference(book, chapter, startVerse, endVerse);
            }
        }
        return null;
    }
}


