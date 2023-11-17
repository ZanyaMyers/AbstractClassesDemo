using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {
       public bool HasSideCar { get; set; }
        public override void DriveAbstract()
        {
            Console.WriteLine("Override the motorcycle abstract method"); 
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("Override the Drive virtual method");
        }


    }
}
