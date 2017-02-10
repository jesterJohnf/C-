using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace averagesAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Prompting the user to enter a number 
            Console.WriteLine("Would you like to add a number to the list? (Y/N)");

            // Declaring global variables 
            string number;
            double total = 0;
            int numbers = 0;

            // Using the class convert to convert and format user input to an upper case character
            char response = Convert.ToChar(Console.ReadLine().ToUpper());

            // Switch statement used to guide user input 
            switch (response)
            {
                case 'Y':
                    Console.WriteLine("Please enter a number, followed by return.");
                    
                    Console.WriteLine("Press return again to calculate the average of the numbers inputted.");
                    break;

                    numbers = Convert.ToInt32(Console.ReadLine());

                case 'N':
                    Console.WriteLine("Press ‘X’ to exit:");
                    break;
            }
           
            // While loop used to store numbers inputted by user
            while ((number = Console.ReadLine()) != "")
            {
                  total += double.Parse(number); // Use of += operator allows something to add to itself, in this case number(s) inputted
                  numbers++; // Increments numbers inputted by 1 
            }

            // Calculating the average of the numbers and outputting the sum to the user 
            Console.WriteLine("The average of the numbers entered is: {0}", total / numbers);
            Console.WriteLine();
            Console.WriteLine("The sum of the numbers entered is: {0}", total);


        } // End main
    } // End program class
} // End namespace
