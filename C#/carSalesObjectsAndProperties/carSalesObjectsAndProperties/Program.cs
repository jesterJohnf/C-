using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carSalesObjectsAndProperties
{
    class Car
    {
       public string make;
       public string model;
       public int price;
       public Boolean sold;

       public static int numberOfCars;

       public Car(string make, string model, int price) // Constructor (replacing the previous addCar method, same name as the class and removing return type)

       {
            this.make = make;
            this.model = model;
            this.price = price;
            this.sold = false;
            Car.numberOfCars++;
       }
        public void ListCar()
        {
            // Display details for an individual car
            Console.WriteLine("The details of this car are: ");
            Console.Write("Make and model: {0} {1}, price: £{2:N0}.", make, model, price);  //:N0 formats the number
            if (sold)
            {
                Console.WriteLine("This car has been sold.");
            }
            else
            {
                Console.WriteLine("This car has not yet been sold.");
            }
            Console.WriteLine();
        }
        //record the sale of a car
        public void Sold(bool isSold, int price)
        {
            this.sold = isSold;
            this.price = price;
            //adjust the number of cars
            Car.numberOfCars--;
        }

        // Listing all the cars
        public static void ListAllCars(List<Car> allCars)
        {
            int totalValueSold = 0;
            int totalValueInStock = 0;

            foreach (Car item in allCars)
            {
                Console.WriteLine("The details of this car are: ");
                Console.Write("Make and model: {0} {1}, price: £{2:N0}.", item.make, item.model, item.price);  //:N0 formats the number
                if (item.sold)
                {
                    Console.WriteLine("This car has been sold.");
                    totalValueSold += item.price;
                }
                else
                {
                    Console.WriteLine("This car is unsold.");
                    totalValueInStock += item.price;
                }
                Console.WriteLine();
            }
            Console.WriteLine("The total value of cars sold is: £{0:N0}.", totalValueSold);
            Console.WriteLine("The total value of cars still in stock is: £{0:N0}.", totalValueInStock);
            Console.WriteLine();
        }


    } // End car class

 class Program
    {
        static void Main(string[] args)
        {
            Car.numberOfCars = 0;
            List<Car> allCars = new List<Car>();

            // Adding cars using the new constructor (now when adding a car this is now achieved using 1 line of code compared to 4 previously) 
            Car car1 = new Car("Volkswagen", "New Beetle", 17000);
            allCars.Add(car1); // Local still var needed to display List!!!
            
            Car car2 = new Car("Mercedes Benz", "C-Class", 28000);
            allCars.Add(car2);

            Car car3 = new Car("Porsche", "911", 76000);
            allCars.Add(car3);

            // Display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine();

            Car.ListAllCars(allCars);

            // Record the sale of a car
            car3.Sold(true, 70000);

            // Display cars data
            Console.WriteLine("Total number of cars in stock is: {0}", Car.numberOfCars);
            Console.WriteLine();

            Car.ListAllCars(allCars);



        } // End main
    }
}
