using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arrayExceptionError
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersArray = new int[3] { 0, 1, 2};

            try
            {
                for (int i = 0; i <= numbersArray.Length; i++)
                {
                    Console.WriteLine("Next number is : {0}", numbersArray[i]);
                }
            }
            catch (IndexOutOfRangeException e)

            {
                Console.WriteLine("You have gone off the end of the array, check the loop.");
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("That is all");
            }
        }
    }
}
