using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Common.Models.Family
{
    public interface IFamily
    {
        string Name { get; }
        string Mom { get; }
        string Dad { get;  }
        string Child1 { get; }
        string Child2 { get; }

    }
}
