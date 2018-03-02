using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterSample
{
    public class AdaptedLamp : AmericanLamp, IEuropeanPowerPlug
    {
        // wrapping (adapting) the property.
        public bool IsPluggedIntoEuropeanPowerOutlet
        {
            get => IsPluggedIntoAmericanPowerOutlet;
            set
            {
                IsPluggedIntoAmericanPowerOutlet = true;
            }
        }
    }
}
