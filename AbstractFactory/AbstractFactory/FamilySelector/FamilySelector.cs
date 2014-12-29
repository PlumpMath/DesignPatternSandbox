using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AbstractFactory.FamilyFactory;
using Common.Models.Family;

namespace AbstractFactory.FamilySelector
{
    public class FamilySelector<TFamily> where TFamily : IFamily, new()
    {

        private IFamilyFactory _familyFactory;

        public FamilySelector()
        {
            _familyFactory = new FamilyFactory<TFamily>();
        }

        public void Main()
        {
            _familyFactory.IntroduceFamily();
        }

    }
}
