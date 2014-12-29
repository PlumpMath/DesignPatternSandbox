using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder.VehicleBuilder;
using Common.Models.Manufacturers;

namespace Builder{

    public class VehicleDirector
    {

        public void Build(IVehicleBuilder builder)
        {
            builder.BuildEngine();
            builder.InstallWheels();
            builder.PaintVehicle();
            builder.PremierePackage();
        }



    }
}
