using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models.Manufacturers;

namespace Common
{
    public class Vehicle
    {
        public string Name { get; private set; }
        public IManufacturer Manufacturer { get; set; }
        public string Wheels { get; set; }
        public string Body { get; set; }
        public string Engine { get; set; }

        public Vehicle(IManufacturer manufacturer, string name)
        {
            Name = name;
            Manufacturer = manufacturer;
        }

        public void DisplayVehicle()
        {
            Console.WriteLine("{0} {1} {2} {3} {4}", Manufacturer.Name, Name, Wheels, Body, Engine);
        }
    }
}
