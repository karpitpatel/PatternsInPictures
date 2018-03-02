using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    class Program
    {
        static void PlugIntoEuropeanOutlet(IEuropeanPowerPlug europeanPowerPlug)
        {
            europeanPowerPlug.IsPluggedIntoEuropeanPowerOutlet = true;
        }

        static void Main(string[] args)
        {
            IEuropeanPowerPlug adaptedLamp = new AdaptedLamp() { IsSwitchOn = true };

            PlugIntoEuropeanOutlet(adaptedLamp);
        }
    }
}
