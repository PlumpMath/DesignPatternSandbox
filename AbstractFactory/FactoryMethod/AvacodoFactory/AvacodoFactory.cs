using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common.Models;
using Common.Models.Avacodoes;

namespace FactoryMethod.AvacodoFactory
{
    public class AvacodoFactory : IAvacodoFactory
    {
        public IAvacodo CreateAvacodo(string season)
        {
            if (season.Equals("Summer"))
            {
                return new AvacodoSouthAfrica();
            }
            else if (season.Equals("Winter"))
            {
                return new AvacodoSpain();
            }
            else
            {
                return new AvacadoCheap();   
            }
        }
    }
}
