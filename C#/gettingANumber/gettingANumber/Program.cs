using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gettingANumber
{
    class Program
    {
        static void Main(string[] args)
        {
            //tell the user about the program
            Console.WriteLine("I am thinking of a number...");
            //set the value of the number
            int myNum = 5;
            //initialise the response
            int response = 0;

            //prompt the user
            Console.Write("Please type a number: ");
            //get the response
            response = Convert.ToInt32(Console.ReadLine());

            //check if the number is correct
            if (response == myNum)
            {
                Console.WriteLine("That's my number, how did you know?!");
            }
            //if it's wrong, then say if it's higher or lower than the correct number
            else if (response < myNum)
            {
                Console.WriteLine("Close, but not quite the number that I'm thinking of...");
            }
            else
            {
                Console.WriteLine("Not quite! That number is greater than the one I am thinking of...");
            }
        }//end main
    }//end program
}//end namespace
       
        

     

            

