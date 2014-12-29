using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory;
using AbstractFactory.FamilySelector;
using Builder;
using Common.Models;
using Common.Models.Family;
using Common.Models.Manufacturers;
using FactoryMethod.AvacodoFactory;

namespace Client
{
    class Program
    {
        static void Main(string[] args)
        {
            VehicleBuilder();

            Console.ReadLine();
        }

        private static void VehicleBuilder()
        {
            var director = new VehicleDirector();
            var builder = new FordCompactBuilder();

            director.Build(builder);
            var vehicle = builder.GetVehicle();
            vehicle.DisplayVehicle();
        }

        private static void AvacodoFactory()
        {
            var avacodoFactory = new AvacodoFactory();
            var avacodoList = new List<IAvacodo>();

            avacodoList.Add(avacodoFactory.CreateAvacodo("Summer"));
            avacodoList.Add(avacodoFactory.CreateAvacodo("Winter"));
            avacodoList.Add(avacodoFactory.CreateAvacodo("Any avacodo will do."));

            foreach (var avacodo in avacodoList)
            {
                Console.WriteLine(avacodo.Name);
            }
        }
    }
}
