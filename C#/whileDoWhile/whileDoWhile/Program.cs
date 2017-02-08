using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whileDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            string ans1;

            do
            {
                Console.WriteLine("Why did the chicken cross the road?");
                ans1 = (Console.ReadLine());
            } while (ans1 != "To get to the other side");
            Console.WriteLine("That is correct, he lived happily ever after");
        }
    }
}
