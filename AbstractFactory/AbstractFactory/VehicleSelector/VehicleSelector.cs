using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models.Manufacturers;


namespace AbstractFactory
{
    public class VehicleSelector<TManufacturer> where TManufacturer : IManufacturer, new()
    {

        public void Main()
        {
            var factory = new VehicleFactory<TManufacturer>();

            factory.CreateCompact();
            factory.CreateSport();
            factory.CreateTruck();
        }
    }
}
