using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Avacodoes
{
    public class AvacadoCheap : IAvacodo
    {
        public string Name { get; private set; }

        public AvacadoCheap()
        {
            Name = "The first avacado I could find";
        }
    }
}
