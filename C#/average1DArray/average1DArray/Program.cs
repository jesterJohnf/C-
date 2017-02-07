using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace average1DArray
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tell the user about the program
            Console.WriteLine("Please enter 5 numbers to be averaged, pressing return after each:");

            int[] numbers = new int[5];

            // Loop to get all the numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Please enter another number");
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

        

        Console.WriteLine("Thank you for entering 5 numbers.");

            double total = 0D;

            // Sum the numbers
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
    // Calculate the average
    double average = total / (numbers.Length);

    // Give the user the total
    Console.WriteLine("The average is of your 5 numbers is: {0}", average);

           
            
        } // End main
    } // End program class
} // End namespace
