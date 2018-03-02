using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    public interface IAmericanPowerPlug
    {
        bool IsPluggedIntoAmericanPowerOutlet { get; set; }
    }
}
