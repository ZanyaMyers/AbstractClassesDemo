using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal abstract class Vehicle
    {
        public string Year { get; set; } = "Default Year";
        public string Make { get; set; } = "Defualt Make";
        public string Model { get; set; } = "Defualt Model";

        public abstract void DriveAbstract();

        public virtual void DriveVirtual() 
        {
            Console.WriteLine("Base Implementation");
        }
        

    }
}
