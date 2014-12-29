namespace Common.Models.Manufacturers
{
    public class GM : IManufacturer
    {
        public string Name { get; private set; }
        public string Compact { get; private set; }
        public string Sport { get; private set; }
        public string Truck { get; private set; }

        public GM()
        {
            Name = "GM";
            Compact = "Cobalt";
            Sport = "Corvette";
            Truck = "Silverado";
        }


    }
}
