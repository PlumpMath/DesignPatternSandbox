using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models
{

    public class AvacodoSpain : IAvacodo
    {
        public string Name { get; private set; }

        public AvacodoSpain()
        {
            Name = "Spanish Avacodo";
        }
    }
}
