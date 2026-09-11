using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();

        string choice = "";

        List<string> prompts = new List<string>
        {
            "What was the best part of my day?",
            "Who was the most interesting person I interacted with today?",
            "What was the strongest emotion I felt today?",
            "What did I learn today?",
            "What is something I am grateful for today?",
            "What is one thing I would like to improve tomorrow?"
        };

        Random random = new Random();

        // Creativity: The menu changes dynamically based on the current
        // state of the journal, showing only options that are currently useful.

        while (choice != "5")
        {
            Console.WriteLine();
            Console.WriteLine("Please select one of the following choices:");

            // Write is always available.
            Console.WriteLine("1. Write");

            // Display is only useful when there are entries.
            if (journal._entries.Count > 0)
            {
                Console.WriteLine("2. Display");
            }

            // Load is always available so an existing journal can be loaded.
            Console.WriteLine("3. Load");

            // Save is only useful when there are entries.
            if (journal._entries.Count > 0)
            {
                Console.WriteLine("4. Save");
            }

            Console.WriteLine("5. Quit");
            Console.Write("What would you like to do? ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                int index = random.Next(prompts.Count);
                string prompt = prompts[index];

                Console.WriteLine();
                Console.WriteLine(prompt);

                Console.Write("Your answer: ");
                string response = Console.ReadLine();

                string date = DateTime.Now.ToShortDateString();

                Entry newEntry = new Entry(date, prompt, response);

                journal.AddEntry(newEntry);

                Console.WriteLine();
                Console.WriteLine("Entry added successfully!");
            }
            else if (choice == "2")
            {
                if (journal._entries.Count == 0)
                {
                    Console.WriteLine("There are no entries in the journal.");
                }
                else
                {
                    Console.WriteLine();
                    journal.Display();
                }
            }
            else if (choice == "3")
            {
                Console.Write("What is the filename? ");
                string filename = Console.ReadLine();

                try
                {
                    journal.LoadFromFile(filename);
                    Console.WriteLine("Journal loaded successfully!");
                }
                catch (Exception)
                {
                    Console.WriteLine("Could not load the file.");
                }
            }
            else if (choice == "4")
            {
                if (journal._entries.Count == 0)
                {
                    Console.WriteLine("There are no entries to save.");
                }
                else
                {
                    Console.Write("What is the filename? ");
                    string filename = Console.ReadLine();

                    try
                    {
                        journal.SaveToFile(filename);
                        Console.WriteLine("Journal saved successfully!");
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Could not save the file.");
                    }
                }
            }
            else if (choice == "5")
            {
                Console.WriteLine("Goodbye!");
            }
            else
            {
                Console.WriteLine("Invalid choice. Please select an available option.");
            }
        }
    }
}
