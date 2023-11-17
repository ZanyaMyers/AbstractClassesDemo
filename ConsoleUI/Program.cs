using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle - done 
             * The vehicle class shall have three string properties: Year, Make, and Model - done 
             * Set the defaults of the properties to something generic in the Vehicle class - done 
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation. - done
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation. - done
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle - done 
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle - done
             * Provide the implementations for the abstract methods - done
             * Only in the Motorcycle class will you override the virtual drive method - done
            */

            // Create a list of Vehicle called vehicles - done 
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes - done
            
             * Set the properties values with object initializer syntax n- done
             */
            Vehicle vehicle = new Car() { HasTrunk = true, Year = "2001", Make = "Toyota", Model = "Camry"};
            Vehicle vehicle2 = new Motorcycle() { HasSideCar = true, Year = "2019", Make = "Motor", Model = "Cycle"};
            Car car = new Car() { HasTrunk = false, Year = "3000", Make = "Honda", Model = "Civic"};
            Motorcycle motorcycle = new Motorcycle() {HasSideCar = false, Year = "Another", Make = "Motor", Model = "Cycle"};

            List<Vehicle> Vehicles = new List<Vehicle>() { vehicle, vehicle2, car, motorcycle };
            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            Console.WriteLine("List of the vehicles");
            foreach (var item in Vehicles)  
            {
                Console.WriteLine($"{item.Year} {item.Make} {item.Model}");
            }

            // Call each of the drive methods for one car and one motorcycle

            car.DriveAbstract();
            motorcycle.DriveVirtual();

            #endregion
            Console.ReadLine();
        }
    }
}
