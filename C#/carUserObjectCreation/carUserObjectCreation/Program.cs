using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carUserObjectCreation
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

        class Program
    {
        static void Main(string[] args)
        {
                string make;
                string model;
                int price;


        }
    }
}
