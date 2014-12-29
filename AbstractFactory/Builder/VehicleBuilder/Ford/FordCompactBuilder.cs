using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.VehicleBuilder;
using Common;
using Common.Models.Manufacturers;

namespace Builder
{
    public class FordCompactBuilder : IVehicleBuilder
    {
        private Vehicle _vehicle;

        public FordCompactBuilder()
        {
            _vehicle = new Vehicle(new Ford(),"Focus");
        }

        public void InstallWheels()
        {
            _vehicle.Wheels = @"14"" Steel Wheels";
        }

        public void PaintVehicle()
        {
            _vehicle.Body = "Red";
        }

        public void BuildEngine()
        {
            _vehicle.Engine = "4 Cylinder";
        }

        public void PremierePackage()
        {
            Console.WriteLine("Premiere Package Not Available");
        }

        public Vehicle GetVehicle()
        {
            return _vehicle;
        }
    }
}
