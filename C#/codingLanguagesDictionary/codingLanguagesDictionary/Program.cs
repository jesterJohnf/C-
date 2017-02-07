using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codingLanguagesDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare a dictionary with a string key and string value
            Dictionary<string, string> codingLanguages = new Dictionary<string, string>();

            // Declare variables for accepting user input

            string answer;
            string result;

            // Add entries to dictionary
            codingLanguages.Add("C#", "The best programming language in the world");
            codingLanguages.Add("Java", "Named after it's inventor's favourite cup of coffee");
            codingLanguages.Add("Scratch", "Cool for kids");

            // Prompt user for input and convert it to upper case
            Console.WriteLine("Coding language dictionary. \n Type K to look for a language, \n D to look for a description, ");
            Console.WriteLine("\n L to use a key to look up a value, \n C to count the list and \n X to exit:");
            char response = Convert.ToChar(Console.ReadLine().ToUpper());

            do
            {
                switch (response)
                {
                    // Look up a key
                    case 'K':
                        Console.WriteLine("Type the language that you want to look for:");

                        // Prompting user input
                        answer = Console.ReadLine();
                        if (codingLanguages.ContainsKey(answer)) 
                        Console.WriteLine(answer + " is in the dictionary.");
                        {
                            Console.WriteLine(answer + "is in the dictionary.");
                        } 
                        else
                        {
                            Console.WriteLine(answer + "is not in the dictionary.");
                        }
                        break;

                    case 'C':
                        int totalItems = codingLanguages.Count();
                        Console.WriteLine("There are " + totalItems + " entries in the dictionary.");
                        break;

                    case 'L':
                        Console.WriteLine("Type the language that you want to look up:");
                        answer = Console.ReadLine();
                        string description;
                        codingLanguages.TryGetValue(answer, out description);
                        Console.WriteLine("The description for " + answer + " is " + description);
                        break;

                    default:
                        break;

                }
                Console.WriteLine("Please make another selection: ");
                response = Convert.ToChar(Console.ReadLine().ToUpper());
            }
            while (response != 'X'); // Exit
       }
    }
}
