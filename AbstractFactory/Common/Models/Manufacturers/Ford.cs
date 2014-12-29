
namespace Common.Models.Manufacturers
{
    public class Ford : IManufacturer 
    {
        public string Name { get; private set; }
        
        public string Compact { get; private set; }
        public string Sport { get; private set; }
        public string Truck { get; private set; }
        
        public Ford()
        {
            Name = "Ford";
        }

        
    }
}
