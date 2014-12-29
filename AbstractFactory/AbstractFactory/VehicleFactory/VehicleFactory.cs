using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models.Manufacturers;

namespace AbstractFactory
{
    public class VehicleFactory<TManufacturer> : IVehicleFactory where TManufacturer : IManufacturer, new()
    {
        private TManufacturer _manufacturer;

        public VehicleFactory()
        {
            _manufacturer = new TManufacturer();

            Console.WriteLine("Manufacturer:  {0}", _manufacturer.Name);
        }
        
        public void CreateCompact()
        {
            Console.WriteLine("Compact: {0}", _manufacturer.Compact);
        }

        public void CreateSport()
        {
            Console.WriteLine("Sport: {0}", _manufacturer.Sport);
        }

        public void CreateTruck()
        {
            Console.WriteLine("Truck: {0}", _manufacturer.Truck);
        }
    }
}
