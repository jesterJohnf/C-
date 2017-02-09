using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace polymorphismExample
{
    class Polygon
    {
        public void Draw()
        {
            Console.WriteLine("Drawing a polygon.");
        }

    class Rectangle : Polygon
        {
         public override Draw()
            {
                Console.WriteLine("Drawing a rectangle.");
            }
        }
    class Triangle : Polygon
        {
            public new void Draw()
            {
                Console.WriteLine("Drawing a triangle.");
            }
        }
    

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
