using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Family
{
    public class Ferree : IFamily
    {
        public string Name { get; private set; }
        public string Mom { get; private set; }
        public string Dad { get; private set; }
        public string Child1 { get; private set; }
        public string Child2 { get; private set; }

        public Ferree()
        {
            Name = "Ferree";
            Mom = "Joeleen";
            Dad = "Paul";
            Child1 = "Little Paul";
            Child2 = "Lukie";

        }
    }
}
