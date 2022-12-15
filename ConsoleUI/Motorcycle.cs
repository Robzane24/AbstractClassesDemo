using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Motorcycle : Vehicle
    {

        public bool hasSideCar { get; set; }

        public override void DriveAbstract()
        {
            Console.WriteLine("The motorcycle is running");
        }

        public override void DriveVirtual()
        {
            Console.WriteLine("The motorcycle is virtually running");
        }
    }
}
