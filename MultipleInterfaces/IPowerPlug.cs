using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleInterfaces
{
    // plugs into an outlet. 
    public interface IPowerPlug
    {
        bool IsPlugged { get; set; }
    }
}
