using System;
using JournalApp; // Use the namespace where the classes are defined.

namespace JournalApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Journal journal = new Journal(); // Create an instance of the Journal class.
            string filename = "journal.txt"; // Default filename.

            // Load the journal at the start.
            journal.LoadJournal(filename);

            string choice;
            do
            {
                Console.WriteLine("\nJournal Menu:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal");
                Console.WriteLine("4. Load the journal");
                Console.WriteLine("5. Quit");
                Console.Write("Enter your choice: ");
                choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        journal.AddEntry();
                        break;
                    case "2":
                        journal.DisplayJournal();
                        break;
                    case "3":
                        Console.Write($"Enter the filename to save to (default: {filename}): ");
                        string saveFilename = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(saveFilename))
                        {
                            saveFilename = filename; //use default
                        }
                        journal.SaveJournal(saveFilename);
                        break;
                    case "4":
                        Console.Write($"Enter the filename to load from (default: {filename}): ");
                        string loadFilename = Console.ReadLine();
                        if (string.IsNullOrWhiteSpace(loadFilename))
                        {
                            loadFilename = filename; //use default
                        }
                        journal.LoadJournal(loadFilename);
                        break;
                    case "5":
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            } while (choice != "5");

            //save on exit, too.
            journal.SaveJournal(filename);
        }
    }
}
