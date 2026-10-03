using System;

// Exceeding Requirements:
// I ensured that prompts and questions are not repeated in ReflectingActivity 
// and ListingActivity until all items from the list have been shown at least once.

class Program
{
    static void Main(string[] args)
    {
        BreathingActivity breathing = new BreathingActivity();
        ReflectingActivity reflecting = new ReflectingActivity();
        ListingActivity listing = new ListingActivity();

        string choice = "";

        while (choice != "4")
        {
            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("  1. Start breathing activity");
            Console.WriteLine("  2. Start reflecting activity");
            Console.WriteLine("  3. Start listing activity");
            Console.WriteLine("  4. Quit");
            Console.Write("Select a choice from the menu: ");

            choice = Console.ReadLine();

            if (choice == "1")
            {
                breathing.Run();
            }
            else if (choice == "2")
            {
                reflecting.Run();
            }
            else if (choice == "3")
            {
                listing.Run();
            }
            else if (choice == "4")
            {
                Console.WriteLine("\nGoodbye!");
            }
        }
    }
}