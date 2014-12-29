using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models.Family;

namespace AbstractFactory.FamilyFactory
{
    public class FamilyFactory<TFamily> : IFamilyFactory where TFamily : IFamily, new()
    {
        private IFamily _family;

        public FamilyFactory()
        {
            _family = new TFamily();
        }

        public void IntroduceFamily()
        {  
            Console.WriteLine(Environment.NewLine);
            Console.WriteLine("The {0} family", _family.Name);
            Console.WriteLine("The Mom: {0}", _family.Mom);
            Console.WriteLine("The Dad: {0}", _family.Dad);
            Console.WriteLine("Child1: {0}", _family.Child1);
            Console.WriteLine("Child2: {0}", _family.Child2);
            Console.WriteLine(Environment.NewLine);
        }
    }
}
