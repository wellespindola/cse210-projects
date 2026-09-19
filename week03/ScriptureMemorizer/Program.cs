using System;
using System.Collections.Generic;

/*
EXCEEDED REQUIREMENTS / CREATIVITY REPORT:
1. Scripture Library: Instead of using a single hardcoded scripture, this program contains 
   a library of scriptures (including both single-verse and multi-verse references). 
   A random scripture is selected from the library every time the application runs.
2. Smart Word Selection: The program tracks words that are not yet hidden and selects strictly 
   from visible words, preventing the random generator from attempting to re-hide already hidden words.
*/

class Program
{
    static void Main(string[] args)
    {
        List<Scripture> scriptureLibrary = new List<Scripture>
        {
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world that he gave his one and only Son that whoever believes in him shall not perish but have eternal life"
            ),
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all your heart and lean not on your own understanding in all your ways submit to him and he will make your paths straight"
            ),
            new Scripture(
                new Reference("Philippians", 4, 13),
                "I can do all this through him who gives me strength"
            ),
            new Scripture(
                new Reference("Doctrine and Covenants", 6, 36),
                "Look unto me in every thought look not doubt fear not"
            )
        };

       
        Random random = new Random();
        int randomIndex = random.Next(scriptureLibrary.Count);
        Scripture currentScripture = scriptureLibrary[randomIndex];

       
        while (true)
        {
            Console.Clear();
            Console.WriteLine(currentScripture.GetDisplayText());
            Console.WriteLine();

            // Encerra o programa se todas as palavras estiverem ocultas
            if (currentScripture.IsCompletelyHidden())
            {
                break;
            }

            Console.WriteLine("Press Enter to continue or type 'quit' to finish:");
            string input = Console.ReadLine();

            if (input != null && input.Trim().ToLower() == "quit")
            {
                break;
            }

           
            currentScripture.HideRandomWords(3);
        }
    }
}