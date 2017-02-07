using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dwarvesDinners
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] sevenDwarves = { "Happy", "Doc", "Sleepy", "Sneezy", "Dopey", "Bashful", "Grumpy" };

            // Telling each dwarf that his dinner is ready using a for loop
            for (int i = 0; i < sevenDwarves.Length; i++)  

            {
                Console.WriteLine("Here is your dinner, " + sevenDwarves[i]);
            }

            foreach (string i in sevenDwarves)
            {
                Console.WriteLine("And here is a nice warm drink, " + i);
            }


        }
    }
}
