using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carSalesInheritance
{
    class Vehicle // Creating a vehicle class
    {
        public string make;
        public string model;
        public int price;
        public Boolean sold;

        public static int totalValueSold = 0;
        public static int totalValueInStock = 0;

        public Vehicle(string make, string model, int price) // Vehicle constructor 

        {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            totalValueInStock += price;
        }

        public void DisplayOneVehicle();
        {
          // Displaying details for an individual car
          Console.WriteLine("The details for this vehicle are:");
          Console.WriteLine("Make and model: {0} {1}, price: £{2:N0}.", make, model, price);  //:N0 formats the number   

          if(sold) // If else to display if car has been sold/unsold
            {
             Console.WriteLine("This car has been sold.", item.type);
            }
          else 
            {
             Console.WriteLine("This has not yet been sold.", item.type);
            }
             Console.WriteLine();
         }

    // Recording the sale of vehicle
    public void SoldOneVehicle(bool isSold, int price)
{

}









    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
